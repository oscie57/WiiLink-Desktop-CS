using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WiiLink_Desktop_CS
{
    internal static class Program
    {
        public static Options Options = new();
        public static Config Config = new();
        public static Event Event = new();

        public static List<PosterMeta> PosterMetaList = new List<PosterMeta>();

        public static HttpClient HttpClient = new();

        public static SoundPlayer BGM_Main1 = new(Properties.Resources.BGM_Main1);
        public static SoundPlayer BGM_Main2 = new(Properties.Resources.BGM_Main2);
        public static SoundPlayer BGM_Settings = new(Properties.Resources.BGM_Settings);
        public static SoundPlayer BGM_Theatre = new(Properties.Resources.BGM_Theatre);

        public static void LoadAppConfig()  // Loads App Configuration
        {
            if (!File.Exists("config.json"))  // Checks if the config file does not exist
            {
                Form_Settings Form_Settings = new();  // Makes a new instance of the Settings Form
                Form_Settings.ShowDialog();  // Displays the form
            }

            string configtext = File.ReadAllText("config.json");  // Reads the config file
            Options = JsonSerializer.Deserialize<Options>(configtext);  // Deserialises the JSON and puts it into the Options object
        }

        public static async Task<bool> GetXMLConfig_First()
        {
            try
            {
                // Define the key and IV for first.bin
                byte[] FIRST_BIN_KEY = [0x94, 0x3B, 0x13, 0xDD, 0x87, 0x46, 0x8B, 0xA5, 0xD9, 0xB7, 0xA8, 0xB8, 0x99, 0xF9, 0x18, 0x03];
                byte[] FIRST_BIN_IV = [0x66, 0xB3, 0x3F, 0xC1, 0x37, 0x3F, 0xE5, 0x06, 0xEC, 0x2B, 0x59, 0xFB, 0x6B, 0x97, 0x7C, 0x82];

                // Get the first.bin file and ensure it is successful
                string FirstBinURL = $"{Options.ServerURL}/conf/first.bin";  // Set the URL for first.bin
                HttpResponseMessage FirstResponse = await HttpClient.GetAsync(FirstBinURL);
                FirstResponse.EnsureSuccessStatusCode();

                // Read the first.bin content, decrypt it, and deserialize it into the Config object
                byte[] EncryptedXML = await FirstResponse.Content.ReadAsByteArrayAsync();
                AesHelper AesHelper = new(FIRST_BIN_KEY, FIRST_BIN_IV);
                string DecryptedXML = AesHelper.Decrypt(EncryptedXML);
                XmlSerializer FirstSerializer = new(typeof(Config));

                using TextReader Reader = new StringReader(DecryptedXML);
                Config = (Config)FirstSerializer.Deserialize(Reader);

                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return false;
            }
        }
        public static async Task<bool> GetXMLConfig_Event()
        {
            try
            {
                // Get the today.xml file and ensure it is successful
                string EventURL = $"{Config.url1}/event/today.xml";
                var EventResponse = await HttpClient.GetAsync(EventURL);
                EventResponse.EnsureSuccessStatusCode();

                // Read the today.xml content and deserialize it into the Event object
                var XML = await EventResponse.Content.ReadAsStringAsync();

                XmlSerializer EventSerializer = new(typeof(Event));

                using (TextReader Reader = new StringReader(XML))
                {
                    Event = (Event)EventSerializer.Deserialize(Reader);
                }

                foreach (posterinfo PosterInfo in Event.posterinfo)
                {
                    var PosterURL = $"{Config.url1}/wall/{PosterInfo.posterid}.met";
                    var PosterResponse = await HttpClient.GetAsync(PosterURL);
                    PosterResponse.EnsureSuccessStatusCode();

                    var PosterXML = await PosterResponse.Content.ReadAsStringAsync();

                    XmlSerializer PosterSerializer = new(typeof(PosterMeta));

                    using (TextReader Reader = new StringReader(PosterXML))
                    {
                        PosterMeta PosterMeta = (PosterMeta)PosterSerializer.Deserialize(Reader);
                        PosterMetaList.Add(PosterMeta);
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  // The main function that runs on boot
        {
            Application.EnableVisualStyles();  // Enables visual styles
            Application.SetCompatibleTextRenderingDefault(false);  // Sets the text rendering to be compatible with the system

            // Setup HttpClient User-Agent
            HttpClient.DefaultRequestHeaders.UserAgent.Add(new("Gex", "4"));
            bool success;

            LoadAppConfig();  // Loads config.json into the Options object

            // Fetch and process the Config
            var task = Task.Run(async () => await GetXMLConfig_First());
            task.Wait();
            success = task.Result;

            if (!success)
            {
                // TODO: pass the error information
                Application.Run(new Form_Error());  // Displays the error form
                return;
            }

            // Fetch and process the Event
            task = Task.Run(async () => await GetXMLConfig_Event());
            task.Wait();
            success = task.Result;

            if (!success)
            {
                // TODO: pass the error information
                Application.Run(new Form_Error());  // Displays the error form
                return;
            }

            // run the shit
            if (!Config.maint)  // If the server is not in maintenance mode
            {
                Application.Run(new Form_Main());  // Runs the main form
            }
            else  // If the server is in maintenance mode
            {
                Application.Run(new Form_Error());  // Displays the error form
            }
        }
    }
}
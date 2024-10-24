using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Media;
using System.Net;
using System.Drawing.Text;
using System.Net.Http;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WiiLink_Desktop_CS
{
    internal static class Program
    {
        public static Options Options = new();
        public static Config Config = new();
        public static Event Event = new();

        public static List<PosterMeta> PosterMetaList = new List<PosterMeta>();

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

        public static async void GetXMLConfig()
        {
            // Define the key and IV for first.bin
            byte[] FIRST_BIN_KEY = [0x94, 0x3B, 0x13, 0xDD, 0x87, 0x46, 0x8B, 0xA5, 0xD9, 0xB7, 0xA8, 0xB8, 0x99, 0xF9, 0x18, 0x03];
            byte[] FIRST_BIN_IV = [0x66, 0xB3, 0x3F, 0xC1, 0x37, 0x3F, 0xE5, 0x06, 0xEC, 0x2B, 0x59, 0xFB, 0x6B, 0x97, 0x7C, 0x82];

            // Define information for first.bin
            string FirstBinURL = $"{Options.ServerURL}/conf/first.bin";  // Set the URL for first.bin

            // Create a new HttpClient for first.bin and input information
            HttpClient FirstClient = new();
            FirstClient.BaseAddress = new Uri(FirstBinURL);
            FirstClient.DefaultRequestHeaders.UserAgent.Add(new("Gex", "4"));

            // Get the first.bin file and ensure it is successful
            HttpResponseMessage FirstResponse = FirstClient.GetAsync(FirstClient.BaseAddress).Result;
            FirstResponse.EnsureSuccessStatusCode();
            
            // Decrypt the first.bin
            byte[] EncryptedXML = await FirstResponse.Content.ReadAsByteArrayAsync();

            AesHelper AesHelper = new(FIRST_BIN_KEY, FIRST_BIN_IV);
            string DecryptedXML = AesHelper.Decrypt(EncryptedXML);

            // Serialise the file into the Config object
            XmlSerializer FirstSerializer = new(typeof(Config));

            using (TextReader Reader = new StringReader(DecryptedXML))
            {
                Config = (Config)FirstSerializer.Deserialize(Reader);
            }

            // Get the event information
            string EventURL = $"{Config.url1}/event/today.xml";
            HttpClient EventClient = new();
            EventClient.BaseAddress = new Uri(EventURL);
            EventClient.DefaultRequestHeaders.UserAgent.Add(new("Gex", "4"));

            HttpResponseMessage EventResponse = EventClient.GetAsync(EventClient.BaseAddress).Result;
            EventResponse.EnsureSuccessStatusCode();

            string XML = EventResponse.Content.ReadAsStringAsync().Result;

            XmlSerializer EventSerializer = new(typeof(Event));

            using (TextReader Reader = new StringReader(XML))
            {
                Event = (Event)EventSerializer.Deserialize(Reader);
            }

            foreach (posterinfo PosterInfo in Event.posterinfo)
            {
                string PosterURL = $"{Config.url1}/wall/{PosterInfo.posterid}.met";
                HttpClient PosterClient = new();
                PosterClient.BaseAddress = new Uri(PosterURL);
                PosterClient.DefaultRequestHeaders.UserAgent.Add(new("Gex", "4"));

                HttpResponseMessage PosterResponse = PosterClient.GetAsync(PosterClient.BaseAddress).Result;
                PosterResponse.EnsureSuccessStatusCode();

                string PosterXML = await PosterResponse.Content.ReadAsStringAsync();

                XmlSerializer PosterSerializer = new(typeof(PosterMeta));

                using (TextReader Reader = new StringReader(PosterXML))
                {
                    PosterMeta PosterMeta = (PosterMeta)PosterSerializer.Deserialize(Reader);
                    PosterMetaList.Add(PosterMeta);
                }
                
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  // The main function that runs on boot
        {
            LoadAppConfig();  // Loads config.json into the Options object
            GetXMLConfig();  // Obtains and loads the XML configuration to the Config and Event objects

            Application.EnableVisualStyles();  // Enables visual styles
            Application.SetCompatibleTextRenderingDefault(false);  // Sets the text rendering to be compatible with the system

            if ( !Config.maint)  // If the server is not in maintenance mode
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

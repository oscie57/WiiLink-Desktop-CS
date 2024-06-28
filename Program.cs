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

namespace WiiLink_Desktop_CS
{
    internal static class Program
    {
        public static RootConfig Config = new();
        public static FirstConfig FirstConfig = new();

        public static SoundPlayer BGM_Main1 = new(Properties.Resources.BGM_Main1);
        public static SoundPlayer BGM_Main2 = new(Properties.Resources.BGM_Main2);
        public static SoundPlayer BGM_Settings = new(Properties.Resources.BGM_Settings);
        public static SoundPlayer BGM_Theatre = new(Properties.Resources.BGM_Theatre);

        public static void LoadAppConfig()
        {    
            if (!File.Exists("config.json"))
            {
                Form_Settings Form_Settings = new();
                Form_Settings.ShowDialog();
            }

            string configtext = File.ReadAllText("config.json");
            Config = JsonSerializer.Deserialize<RootConfig>(configtext);
        }

        public static async void LoadFirstConfig()
        {
            byte[] FIRST_BIN_KEY = new byte[] { 0x94, 0x3B, 0x13, 0xDD, 0x87, 0x46, 0x8B, 0xA5, 0xD9, 0xB7, 0xA8, 0xB8, 0x99, 0xF9, 0x18, 0x03 };
            byte[] FIRST_BIN_IV = new byte[] { 0x66, 0xB3, 0x3F, 0xC1, 0x37, 0x3F, 0xE5, 0x06, 0xEC, 0x2B, 0x59, 0xFB, 0x6B, 0x97, 0x7C, 0x82 };

            string FirstBinURL = $"{Config.ServerURL}/conf/first.bin";

            HttpClient SharedClient = new();
            SharedClient.BaseAddress = new Uri(FirstBinURL);
            SharedClient.DefaultRequestHeaders.UserAgent.Add(new("Gex", "2"));

            using HttpResponseMessage response = await SharedClient.GetAsync(SharedClient.BaseAddress);
            response.EnsureSuccessStatusCode();
            
            byte[] EncryptedXML = await response.Content.ReadAsByteArrayAsync();

            AesHelper AesHelper = new(FIRST_BIN_KEY, FIRST_BIN_IV);
            string DecryptedXML = AesHelper.Decrypt(EncryptedXML);

            XmlSerializer Serializer = new(typeof(FirstConfig));

            using (TextReader Reader = new StringReader(DecryptedXML))
            {
                FirstConfig = (FirstConfig)Serializer.Deserialize(Reader);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadAppConfig();
            LoadFirstConfig();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if ( !FirstConfig.maint )
            {
                Application.Run(new Form_Main());
            }
            else
            {
                Application.Run(new Form_Error());
            }
            
        }
    }
}

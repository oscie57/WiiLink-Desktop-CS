﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace WiiLink_Desktop_CS
{
    internal static class Program
    {
        public static RootConfig Config = new RootConfig();

        public static string FirstBinURL;
        public static bool maintenance;

        public static void LoadConfig()
        {    
            if (!File.Exists("config.json"))
            {
                Application.Run(new Form_Settings());
            }
            else
            {
                string configtext = File.ReadAllText("config.json");
                Config = JsonSerializer.Deserialize<RootConfig>(configtext);
            }
        }

        public static void GetFirstData()
        {
            FirstBinURL = $"{Config.ServerURL}/conf/first.bin";
            maintenance = false;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadConfig();
            GetFirstData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (maintenance == false)
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
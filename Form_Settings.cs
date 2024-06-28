﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiiLink_Desktop_CS
{
    public partial class Form_Settings : Form
    {
        RootConfig Config = Program.Config;

        public Form_Settings()
        {
            InitializeComponent();
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            if (File.Exists("config.json"))
            {
                string configtext = File.ReadAllText("config.json");
                Config = JsonSerializer.Deserialize<RootConfig>(configtext);

                Text_WiiNo.Text = Config.WiiNo.ToString();
                Combo_WiiType.SelectedIndex = (int)Config.WiiType;
                Text_DiscordID.Text = Config.DiscordID.ToString();
                Text_ServerURL.Text = Config.ServerURL;
                Check_PlayAudio.Checked = Config.PlayAudio;
            }
            else
            {
                Text_ServerURL.Text = "http://prod.wiilink24.com";
                Check_PlayAudio.Checked = true;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            // check all fields are filled 
            if ( string.IsNullOrEmpty(Text_WiiNo.Text) || string.IsNullOrEmpty(Combo_WiiType.Text) || string.IsNullOrEmpty(Text_DiscordID.Text) || string.IsNullOrEmpty(Text_ServerURL.Text) )
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // remove spaces from WiiNo
            string WiiNoFix = Text_WiiNo.Text.Replace(" ", "");
            // check if WiiNo and DiscordID are numbers
            if ( !ulong.TryParse(WiiNoFix, out _) || !ulong.TryParse(Text_DiscordID.Text, out _) )
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if WiiNo is 16 digits
            if ( WiiNoFix.Length != 16 )
            {
                MessageBox.Show("Please enter a 16 digit number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if ServerURL is a valid URL
            if ( !Uri.IsWellFormedUriString(Text_ServerURL.Text, UriKind.Absolute) )
            {
                MessageBox.Show("Please enter a valid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if WiiType is selected
            if ( Combo_WiiType.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select a Wii Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // convert WiiType to WiiType enum
            ulong WiiNo = ulong.Parse(WiiNoFix);
            WiiType WiiType = (WiiType)Combo_WiiType.SelectedIndex;
            ulong DiscordID = ulong.Parse(Text_DiscordID.Text);
            string ServerURL = Text_ServerURL.Text;
            bool PlayAudio = Check_PlayAudio.Checked;

            Config.WiiNo = WiiNo;
            Config.WiiType = WiiType;
            Config.DiscordID = DiscordID;
            Config.ServerURL = ServerURL;
            Config.PlayAudio = PlayAudio;

            string json = JsonSerializer.Serialize(Config);
            File.WriteAllText("config.json", json);
            MessageBox.Show("Settings saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

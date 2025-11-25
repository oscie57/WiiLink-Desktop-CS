using System;
using System.IO;
using System.Media;
using System.Text.Json;
using System.Windows.Forms;

namespace WiiLink_Desktop_CS
{
    public partial class Form_Settings : Form
    {
        Options Options = Program.Options;

        SoundPlayer BGM_Main1 = Program.BGM_Main1;
        SoundPlayer BGM_Main2 = Program.BGM_Main2;
        SoundPlayer BGM_Settings = Program.BGM_Settings;
        SoundPlayer BGM_Theatre = Program.BGM_Theatre;

        public Form_Settings()
        {
            InitializeComponent();
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            BGM_Main1.Stop();
            BGM_Main2.Stop();
            if (Options.PlayAudio)
            {
                BGM_Settings.PlayLooping();
            }

            if (File.Exists("config.json"))
            {
                var configText = File.ReadAllText("config.json");
                Options = JsonSerializer.Deserialize<Options>(configText);
                Program.Options = Options;
                Text_WiiNo.Text = Options.WiiNo.ToString();
                Combo_WiiType.SelectedIndex = (int)Options.WiiType;
                Text_DiscordID.Text = Options.DiscordID.ToString();
                Text_ServerURL.Text = Options.ServerURL;
                Check_PlayAudio.Checked = Options.PlayAudio;
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
            if (string.IsNullOrEmpty(Text_WiiNo.Text) || string.IsNullOrEmpty(Combo_WiiType.Text) || string.IsNullOrEmpty(Text_DiscordID.Text) || string.IsNullOrEmpty(Text_ServerURL.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // remove spaces from WiiNo
            var wiiNoFix = Text_WiiNo.Text.Replace(" ", "");
            // check if WiiNo and DiscordID are numbers
            if (!ulong.TryParse(wiiNoFix, out _) || !ulong.TryParse(Text_DiscordID.Text, out _))
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if WiiNo is 16 digits
            if (wiiNoFix.Length != 16)
            {
                MessageBox.Show("Please enter a 16 digit number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if ServerURL is a valid URL
            if (!Uri.IsWellFormedUriString(Text_ServerURL.Text, UriKind.Absolute))
            {
                MessageBox.Show("Please enter a valid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if WiiType is selected
            if (Combo_WiiType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Wii Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // convert WiiType to WiiType enum
            var wiiNo = ulong.Parse(wiiNoFix);
            var wiiType = (WiiType)Combo_WiiType.SelectedIndex;
            var discordId = ulong.Parse(Text_DiscordID.Text);
            var ServerURL = Text_ServerURL.Text;
            var PlayAudio = Check_PlayAudio.Checked;

            Options.WiiNo = wiiNo;
            Options.WiiType = wiiType;
            Options.DiscordID = discordId;
            Options.ServerURL = ServerURL;
            Options.PlayAudio = PlayAudio;

            var json = JsonSerializer.Serialize(Options);
            File.WriteAllText("config.json", json);
            Program.Options = Options;
            MessageBox.Show("Settings saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BGM_Settings.Stop();
            if (Options.PlayAudio)
            {
                BGM_Main2.PlayLooping();
            }
            Close();
        }
    }
}

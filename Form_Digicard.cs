using System;
using System.Media;
using System.Windows.Forms;

namespace WiiLink_Desktop_CS
{
    public partial class Form_Digicard : Form
    {
        Options Options = Program.Options;

        SoundPlayer BGM_Main1 = Program.BGM_Main1;
        SoundPlayer BGM_Main2 = Program.BGM_Main2;
        SoundPlayer BGM_Settings = Program.BGM_Settings;
        SoundPlayer BGM_Theatre = Program.BGM_Theatre;

        public Form_Digicard()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            BGM_Theatre.Stop();
            if (Options.PlayAudio)
            {
                BGM_Main2.PlayLooping();
            }
            this.Close();
        }

        private void Form_Digicard_Load(object sender, EventArgs e)
        {
            BGM_Main1.Stop();
            BGM_Main2.Stop();
            if (Options.PlayAudio)
            {
                BGM_Theatre.PlayLooping();
            }

            var discordId = Options.DiscordID;
            var randomizer = Random.Shared.Next(0, 1000000).ToString();
            var cardUrl = $"https://card.wiilink24.com/cards/{discordId}.jpg?randomizer={randomizer}";

            Label_ID.Text = $"Discord ID: {discordId}";
            
            Pic_Card.LoadAsync(cardUrl);
        }
    }
}

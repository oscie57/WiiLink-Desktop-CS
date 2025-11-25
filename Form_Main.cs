using System;
using System.Collections.Generic;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiiLink_Desktop_CS
{
    public partial class Form_Main : Form
    {
        SoundPlayer BGM_Main1 = Program.BGM_Main1;
        SoundPlayer BGM_Main2 = Program.BGM_Main2;
        SoundPlayer BGM_Settings = Program.BGM_Settings;
        SoundPlayer BGM_Theatre = Program.BGM_Theatre;

        public Form_Main()
        {
            InitializeComponent();
        }

        public static async Task ProcessPosterList(string URL, List<PosterMeta> PosterList, PictureBox Pic_Poster, Label Label_Poster)
        {
            while (true)
            {
                foreach (var Poster in PosterList)
                {
                    var posterUrl = $"{URL}/wall/{Poster.posterid}.img";
                    Pic_Poster.LoadAsync(posterUrl);
                    // i decided to swap the msg and the title because
                    // msg displays above the poster in-channel
                    Label_Poster.Text = Poster.msg;
                    await Task.Delay(10_000); //10s delay
                }
            }
        }

        private async void Form_Main_Load(object sender, EventArgs e)
        {
            Label_WiiNoValue.Text = Program.Options.WiiNo.ToString().Insert(4, " ").Insert(9, " ").Insert(14, " ").Insert(19, " ");
            Label_ConsoleTypeValue.Text = Program.Options.WiiType switch
            {
                WiiType.Wii => "Wii",
                WiiType.WiiU => "Wii U",
                WiiType.DolphinEmu => "Dolphin",
                _ => Program.Options.WiiType.ToString()
            };
            Task.Run(async () =>
            {
                await ProcessPosterList(Program.Config.url1, Program.PosterMetaList, Pic_Poster, Label_Poster);
            });

            if (Program.Options.PlayAudio)
            {
                BGM_Main1.PlayLooping();
            }

            Form_MainAnim Form_MainAnim = new();
            Form_MainAnim.ShowDialog();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Settings_Click(object sender, EventArgs e)
        {
            Form_Settings Form_Settings = new();
            Form_Settings.ShowDialog();
        }

        private void Button_Digicard_Click(object sender, EventArgs e)
        {
            Form_Digicard Form_Digicard = new();
            Form_Digicard.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

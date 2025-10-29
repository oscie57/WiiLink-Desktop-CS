using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Media;

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
                foreach (PosterMeta Poster in PosterList)
                {
                    string PosterURL = $"{URL}/wall/{Poster.posterid}.img";
                    Pic_Poster.LoadAsync(PosterURL);
                    // i decided to swap the msg and the title because
                    // msg displays above the poster in-channel
                    Label_Poster.Text = Poster.msg;

                    // Asynchronously wait for 1 second to avoid a tight infinite loop
                    await Task.Delay(10000);
                }
            }
        }

        private async void Form_Main_Load(object sender, EventArgs e)
        {
            Label_WiiNoValue.Text = Program.Options.WiiNo.ToString().Insert(4, " ").Insert(9, " ").Insert(14, " ").Insert(19, " ");
            switch (Program.Options.WiiType)
            {
                case WiiType.Wii:
                    Label_ConsoleTypeValue.Text = "Wii";
                    break;
                case WiiType.WiiU:
                    Label_ConsoleTypeValue.Text = "Wii U";
                    break;
                case WiiType.DolphinEmu:
                    Label_ConsoleTypeValue.Text = "Dolphin";
                    break;
                default:
                    Label_ConsoleTypeValue.Text = Program.Options.WiiType.ToString();
                    break;
            }

            await ProcessPosterList(Program.Config.url1, Program.PosterMetaList, Pic_Poster, Label_Poster);

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

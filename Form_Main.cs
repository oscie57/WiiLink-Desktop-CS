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
        RootConfig Config = Program.Config;

        SoundPlayer BGM_Main1 = Program.BGM_Main1;
        SoundPlayer BGM_Main2 = Program.BGM_Main2;
        SoundPlayer BGM_Settings = Program.BGM_Settings;
        SoundPlayer BGM_Theatre = Program.BGM_Theatre;

        public Form_Main()
        {
            InitializeComponent();

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Label_WiiNoValue.Text = Config.WiiNo.ToString().Insert(4, " ").Insert(9, " ").Insert(14, " ").Insert(19, " ");
            Label_ConsoleTypeValue.Text = Config.WiiType.ToString();

            if ( Config.PlayAudio )
            {
                BGM_Main1.PlayLooping();
            }
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
    }
}

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

namespace WiiLink_Desktop_CS
{
    public partial class Form_Main : Form
    {
        RootConfig Config = Program.Config;

        public Form_Main()
        {
            InitializeComponent();

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Label_WiiNoValue.Text = Config.WiiNo.ToString().Insert(4, " ").Insert(9, " ").Insert(14, " ").Insert(19, " ");
            Label_ConsoleTypeValue.Text = Config.WiiType.ToString();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Settings_Click(object sender, EventArgs e)
        {
            Form_Settings settingsForm = new();
            settingsForm.ShowDialog();
        }
    }
}

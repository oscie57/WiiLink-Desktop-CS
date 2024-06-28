using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiiLink_Desktop_CS
{
    public partial class Form_Digicard : Form
    {
        RootConfig Config = Program.Config;

        public Form_Digicard()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Digicard_Load(object sender, EventArgs e)
        {
            ulong DiscordID = Config.DiscordID;
            string Randomizer = new Random().ToString();
            string CardURL = $"https://card.wiilink24.com/cards/{DiscordID}.jpg?randomizer={Randomizer}";

            Label_ID.Text = "Discord ID: " + DiscordID.ToString();

            Pic_Card.LoadAsync(CardURL);
        }
    }
}

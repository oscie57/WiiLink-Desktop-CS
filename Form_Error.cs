using System;
using System.Windows.Forms;

namespace WiiLink_Desktop_CS
{
    public partial class Form_Error : Form
    {
        Config Config = Program.Config;

        public Form_Error()
        {
            InitializeComponent();
        }

        public string ErrorMessage { get; set; } = "";
        private void Form_Error_Load(object sender, EventArgs e)
        {
            label_debug_text.Text = ErrorMessage;
        }
    }
}

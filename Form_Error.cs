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
    public partial class Form_Error : Form
    {
        Config Config = Program.Config;

        public Form_Error()
        {
            InitializeComponent();
        }

        private void Form_Error_Load(object sender, EventArgs e)
        {
            label_debug_text.Text = """
                1 dpmo
                2 dpmo
                3 dpmo
                """;
        }
    }
}

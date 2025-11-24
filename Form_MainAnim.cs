using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiiLink_Desktop_CS
{
    public partial class Form_MainAnim : Form
    {
        System.Windows.Forms.Timer AnimationTimer = new();
        Options Options = Program.Options;

        public Form_MainAnim()
        {
            InitializeComponent();
        }

        private void StartupAnimation()
        {
            ForeColor = Color.White;
            BackColor = Color.Black;

            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                BackColor = Color.LightSkyBlue;
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                BackColor = Color.LightGoldenrodYellow;
            }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 21)
            {
                BackColor = Color.LightSalmon;
            }
            else
            {
                BackColor = Color.MidnightBlue;
            }

            string DateFormatted = DateTime.Now.ToString(" dd / MM ");

            Label Label_DateText = new()
            {
                Text = DateFormatted,
                Font = new("nintendo_NTLG-DB_002", 64, FontStyle.Underline),
                ForeColor = ForeColor,
                BackColor = BackColor,
                Location = new(0, -40),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new(this.Width, this.Height)
            };

            Panel Panel_Cover = new()
            {
                Size = new(this.Width, this.Height),
                BackColor = BackColor,
                ForeColor = ForeColor,
                Location = new(0, 0)
            };

            this.Controls.Add(Panel_Cover);
            this.Controls.Add(Label_DateText);

            Panel_Cover.BringToFront();
            Label_DateText.BringToFront();
        }

        void AnimationFadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                AnimationTimer.Stop();    //if it is, we stop the timer
                this.Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }

        private async void Form_MainAnim_Load(object sender, EventArgs e)
        {
            StartupAnimation();

            await Task.Delay(2000);

            AnimationTimer.Interval = 100;
            AnimationTimer.Tick += new EventHandler(AnimationFadeOut);
            AnimationTimer.Start();
        }
    }
}

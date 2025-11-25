using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiiLink_Desktop_CS
{
    public partial class Form_MainAnim : Form
    {
        Timer AnimationTimer = new();

        public Form_MainAnim()
        {
            InitializeComponent();
        }

        private void StartupAnimation()
        {
            ForeColor = Color.White;
            BackColor = Color.Black;

            BackColor = DateTime.Now.Hour switch
            {
                >= 6 and < 12 => Color.LightSkyBlue,
                >= 12 and < 18 => Color.LightGoldenrodYellow,
                >= 18 and < 21 => Color.LightSalmon,
                _ => Color.MidnightBlue
            };

            var DateFormatted = DateTime.Now.ToString(" dd / MM ");

            Label Label_DateText = new()
            {
                Text = DateFormatted,
                Font = new("nintendo_NTLG-DB_002", 64, FontStyle.Underline),
                ForeColor = ForeColor,
                BackColor = BackColor,
                Location = new(0, -40),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new(Width, Height)
            };

            Panel Panel_Cover = new()
            {
                Size = new(Width, Height),
                BackColor = BackColor,
                ForeColor = ForeColor,
                Location = new(0, 0)
            };

            Controls.Add(Panel_Cover);
            Controls.Add(Label_DateText);

            Panel_Cover.BringToFront();
            Label_DateText.BringToFront();
        }

        void AnimationFadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                AnimationTimer.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
            {
                Opacity -= 0.0125;
            }
        }

        private async void Form_MainAnim_Load(object sender, EventArgs e)
        {
            StartupAnimation();
            await Task.Delay(2000); // Intentional pause pre animation
            AnimationTimer.Interval = 25; // 25ms per 0.0125 (1.25%) gives us 2 000ms of animation at roughly 40fps (80 frames)
            AnimationTimer.Tick += AnimationFadeOut;
            AnimationTimer.Start();
        }
    }
}

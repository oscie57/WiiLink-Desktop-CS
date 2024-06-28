namespace WiiLink_Desktop_CS
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel_TopBg = new System.Windows.Forms.Panel();
            Label_ConsoleTypeValue = new System.Windows.Forms.Label();
            Label_WiiNoValue = new System.Windows.Forms.Label();
            Label_WiiNoTitle = new System.Windows.Forms.Label();
            Panel_BottomBg = new System.Windows.Forms.Panel();
            Button_Unk2 = new System.Windows.Forms.Button();
            Button_Unk1 = new System.Windows.Forms.Button();
            Button_Digicard = new System.Windows.Forms.Button();
            Button_Settings = new System.Windows.Forms.Button();
            Button_Exit = new System.Windows.Forms.Button();
            Pic_Poster = new System.Windows.Forms.PictureBox();
            Pic_Intro = new System.Windows.Forms.PictureBox();
            Panel_TopBg.SuspendLayout();
            Panel_BottomBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Poster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Intro).BeginInit();
            SuspendLayout();
            // 
            // Panel_TopBg
            // 
            Panel_TopBg.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Panel_TopBg.Controls.Add(Label_ConsoleTypeValue);
            Panel_TopBg.Controls.Add(Label_WiiNoValue);
            Panel_TopBg.Controls.Add(Label_WiiNoTitle);
            Panel_TopBg.Location = new System.Drawing.Point(2, 2);
            Panel_TopBg.Name = "Panel_TopBg";
            Panel_TopBg.Size = new System.Drawing.Size(620, 34);
            Panel_TopBg.TabIndex = 0;
            // 
            // Label_ConsoleTypeValue
            // 
            Label_ConsoleTypeValue.AutoSize = true;
            Label_ConsoleTypeValue.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 12F);
            Label_ConsoleTypeValue.ForeColor = System.Drawing.Color.White;
            Label_ConsoleTypeValue.Location = new System.Drawing.Point(516, 7);
            Label_ConsoleTypeValue.MaximumSize = new System.Drawing.Size(100, 21);
            Label_ConsoleTypeValue.MinimumSize = new System.Drawing.Size(100, 21);
            Label_ConsoleTypeValue.Name = "Label_ConsoleTypeValue";
            Label_ConsoleTypeValue.Size = new System.Drawing.Size(100, 21);
            Label_ConsoleTypeValue.TabIndex = 2;
            Label_ConsoleTypeValue.Text = "Not Set";
            Label_ConsoleTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_WiiNoValue
            // 
            Label_WiiNoValue.AutoSize = true;
            Label_WiiNoValue.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 12F);
            Label_WiiNoValue.ForeColor = System.Drawing.Color.White;
            Label_WiiNoValue.Location = new System.Drawing.Point(127, 7);
            Label_WiiNoValue.Name = "Label_WiiNoValue";
            Label_WiiNoValue.Size = new System.Drawing.Size(204, 21);
            Label_WiiNoValue.TabIndex = 1;
            Label_WiiNoValue.Text = "0000 0000 0000 0000";
            // 
            // Label_WiiNoTitle
            // 
            Label_WiiNoTitle.AutoSize = true;
            Label_WiiNoTitle.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 12F, System.Drawing.FontStyle.Bold);
            Label_WiiNoTitle.ForeColor = System.Drawing.Color.White;
            Label_WiiNoTitle.Location = new System.Drawing.Point(3, 7);
            Label_WiiNoTitle.Name = "Label_WiiNoTitle";
            Label_WiiNoTitle.Size = new System.Drawing.Size(118, 21);
            Label_WiiNoTitle.TabIndex = 0;
            Label_WiiNoTitle.Text = "Wii Number:";
            // 
            // Panel_BottomBg
            // 
            Panel_BottomBg.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Panel_BottomBg.Controls.Add(Button_Unk2);
            Panel_BottomBg.Controls.Add(Button_Unk1);
            Panel_BottomBg.Controls.Add(Button_Digicard);
            Panel_BottomBg.Controls.Add(Button_Settings);
            Panel_BottomBg.Controls.Add(Button_Exit);
            Panel_BottomBg.Location = new System.Drawing.Point(2, 316);
            Panel_BottomBg.Name = "Panel_BottomBg";
            Panel_BottomBg.Size = new System.Drawing.Size(620, 123);
            Panel_BottomBg.TabIndex = 1;
            // 
            // Button_Unk2
            // 
            Button_Unk2.BackColor = System.Drawing.SystemColors.ControlDark;
            Button_Unk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Unk2.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 10F);
            Button_Unk2.Location = new System.Drawing.Point(464, 3);
            Button_Unk2.Name = "Button_Unk2";
            Button_Unk2.Size = new System.Drawing.Size(152, 117);
            Button_Unk2.TabIndex = 4;
            Button_Unk2.Text = "Shows";
            Button_Unk2.UseVisualStyleBackColor = false;
            // 
            // Button_Unk1
            // 
            Button_Unk1.BackColor = System.Drawing.SystemColors.ControlDark;
            Button_Unk1.Enabled = false;
            Button_Unk1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Unk1.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 10F);
            Button_Unk1.Location = new System.Drawing.Point(309, 3);
            Button_Unk1.Name = "Button_Unk1";
            Button_Unk1.Size = new System.Drawing.Size(152, 117);
            Button_Unk1.TabIndex = 3;
            Button_Unk1.Text = "News";
            Button_Unk1.UseVisualStyleBackColor = false;
            // 
            // Button_Digicard
            // 
            Button_Digicard.BackColor = System.Drawing.SystemColors.ControlDark;
            Button_Digicard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Digicard.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 10F);
            Button_Digicard.Location = new System.Drawing.Point(154, 3);
            Button_Digicard.Name = "Button_Digicard";
            Button_Digicard.Size = new System.Drawing.Size(152, 117);
            Button_Digicard.TabIndex = 2;
            Button_Digicard.Text = "Digicard";
            Button_Digicard.UseVisualStyleBackColor = false;
            // 
            // Button_Settings
            // 
            Button_Settings.BackColor = System.Drawing.SystemColors.ControlDark;
            Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Settings.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 10F);
            Button_Settings.Location = new System.Drawing.Point(3, 63);
            Button_Settings.Name = "Button_Settings";
            Button_Settings.Size = new System.Drawing.Size(148, 57);
            Button_Settings.TabIndex = 1;
            Button_Settings.Text = "Settings";
            Button_Settings.UseVisualStyleBackColor = false;
            Button_Settings.Click += Button_Settings_Click;
            // 
            // Button_Exit
            // 
            Button_Exit.BackColor = System.Drawing.SystemColors.ControlDark;
            Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Exit.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 10F);
            Button_Exit.Location = new System.Drawing.Point(3, 3);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new System.Drawing.Size(148, 57);
            Button_Exit.TabIndex = 0;
            Button_Exit.Text = "Exit";
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // Pic_Poster
            // 
            Pic_Poster.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            Pic_Poster.BackgroundImage = Properties.Resources.Poster_Dummy;
            Pic_Poster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Pic_Poster.ErrorImage = Properties.Resources.Poster_Dummy;
            Pic_Poster.Location = new System.Drawing.Point(25, 86);
            Pic_Poster.Name = "Pic_Poster";
            Pic_Poster.Size = new System.Drawing.Size(128, 180);
            Pic_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Pic_Poster.TabIndex = 2;
            Pic_Poster.TabStop = false;
            // 
            // Pic_Intro
            // 
            Pic_Intro.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            Pic_Intro.BackgroundImage = Properties.Resources.Regional_Poster;
            Pic_Intro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Pic_Intro.ErrorImage = Properties.Resources.Regional_Poster;
            Pic_Intro.Location = new System.Drawing.Point(181, 61);
            Pic_Intro.Name = "Pic_Intro";
            Pic_Intro.Size = new System.Drawing.Size(416, 228);
            Pic_Intro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Pic_Intro.TabIndex = 3;
            Pic_Intro.TabStop = false;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            ClientSize = new System.Drawing.Size(624, 441);
            Controls.Add(Pic_Intro);
            Controls.Add(Pic_Poster);
            Controls.Add(Panel_BottomBg);
            Controls.Add(Panel_TopBg);
            Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form_Main";
            Text = "WiiLink Desktop";
            Load += Form_Main_Load;
            Panel_TopBg.ResumeLayout(false);
            Panel_TopBg.PerformLayout();
            Panel_BottomBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pic_Poster).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Intro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Panel_TopBg;
        private System.Windows.Forms.Panel Panel_BottomBg;
        private System.Windows.Forms.PictureBox Pic_Poster;
        private System.Windows.Forms.Button Button_Unk2;
        private System.Windows.Forms.Button Button_Unk1;
        private System.Windows.Forms.Button Button_Digicard;
        private System.Windows.Forms.Button Button_Settings;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.PictureBox Pic_Intro;
        private System.Windows.Forms.Label Label_WiiNoTitle;
        private System.Windows.Forms.Label Label_ConsoleTypeValue;
        private System.Windows.Forms.Label Label_WiiNoValue;
    }
}


namespace WiiLink_Desktop_CS
{
    partial class Form_Settings
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
            Button_Save = new System.Windows.Forms.Button();
            Label_WiiNo = new System.Windows.Forms.Label();
            Label_WiiType = new System.Windows.Forms.Label();
            Combo_WiiType = new System.Windows.Forms.ComboBox();
            Label_DiscordID = new System.Windows.Forms.Label();
            Text_DiscordID = new System.Windows.Forms.TextBox();
            Text_WiiNo = new System.Windows.Forms.MaskedTextBox();
            Label_ServerURL = new System.Windows.Forms.Label();
            Text_ServerURL = new System.Windows.Forms.TextBox();
            Label_PlayAudio = new System.Windows.Forms.Label();
            Check_PlayAudio = new System.Windows.Forms.CheckBox();
            Panel_SaveControls = new System.Windows.Forms.Panel();
            Panel_SaveControls.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Save
            // 
            Button_Save.BackColor = System.Drawing.SystemColors.Control;
            Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Save.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 10F);
            Button_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            Button_Save.Location = new System.Drawing.Point(201, 5);
            Button_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new System.Drawing.Size(175, 38);
            Button_Save.TabIndex = 0;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = false;
            Button_Save.Click += Button_Save_Click;
            // 
            // Label_WiiNo
            // 
            Label_WiiNo.AutoSize = true;
            Label_WiiNo.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 12F);
            Label_WiiNo.Location = new System.Drawing.Point(16, 23);
            Label_WiiNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label_WiiNo.Name = "Label_WiiNo";
            Label_WiiNo.Size = new System.Drawing.Size(101, 21);
            Label_WiiNo.TabIndex = 1;
            Label_WiiNo.Text = "Wii Number";
            // 
            // Label_WiiType
            // 
            Label_WiiType.AutoSize = true;
            Label_WiiType.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 12F);
            Label_WiiType.Location = new System.Drawing.Point(16, 58);
            Label_WiiType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label_WiiType.Name = "Label_WiiType";
            Label_WiiType.Size = new System.Drawing.Size(120, 21);
            Label_WiiType.TabIndex = 3;
            Label_WiiType.Text = "Console Type";
            // 
            // Combo_WiiType
            // 
            Combo_WiiType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Combo_WiiType.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 9F);
            Combo_WiiType.FormattingEnabled = true;
            Combo_WiiType.Items.AddRange(new object[] { "Wii", "Wii U", "Dolphin" });
            Combo_WiiType.Location = new System.Drawing.Point(172, 58);
            Combo_WiiType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Combo_WiiType.Name = "Combo_WiiType";
            Combo_WiiType.Size = new System.Drawing.Size(186, 24);
            Combo_WiiType.TabIndex = 4;
            Combo_WiiType.Text = "Select an item";
            // 
            // Label_DiscordID
            // 
            Label_DiscordID.AutoSize = true;
            Label_DiscordID.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 12F);
            Label_DiscordID.Location = new System.Drawing.Point(16, 93);
            Label_DiscordID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label_DiscordID.Name = "Label_DiscordID";
            Label_DiscordID.Size = new System.Drawing.Size(93, 21);
            Label_DiscordID.TabIndex = 5;
            Label_DiscordID.Text = "Discord ID";
            // 
            // Text_DiscordID
            // 
            Text_DiscordID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Text_DiscordID.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 9F);
            Text_DiscordID.Location = new System.Drawing.Point(172, 93);
            Text_DiscordID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Text_DiscordID.Name = "Text_DiscordID";
            Text_DiscordID.Size = new System.Drawing.Size(186, 23);
            Text_DiscordID.TabIndex = 6;
            // 
            // Text_WiiNo
            // 
            Text_WiiNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Text_WiiNo.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 9F);
            Text_WiiNo.Location = new System.Drawing.Point(172, 23);
            Text_WiiNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Text_WiiNo.Mask = "0000 0000 0000 0000";
            Text_WiiNo.Name = "Text_WiiNo";
            Text_WiiNo.Size = new System.Drawing.Size(186, 23);
            Text_WiiNo.TabIndex = 7;
            // 
            // Label_ServerURL
            // 
            Label_ServerURL.AutoSize = true;
            Label_ServerURL.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 12F);
            Label_ServerURL.Location = new System.Drawing.Point(16, 128);
            Label_ServerURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label_ServerURL.Name = "Label_ServerURL";
            Label_ServerURL.Size = new System.Drawing.Size(101, 21);
            Label_ServerURL.TabIndex = 8;
            Label_ServerURL.Text = "Server URL";
            // 
            // Text_ServerURL
            // 
            Text_ServerURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Text_ServerURL.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 9F);
            Text_ServerURL.Location = new System.Drawing.Point(172, 128);
            Text_ServerURL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Text_ServerURL.Name = "Text_ServerURL";
            Text_ServerURL.Size = new System.Drawing.Size(186, 23);
            Text_ServerURL.TabIndex = 9;
            // 
            // Label_PlayAudio
            // 
            Label_PlayAudio.AutoSize = true;
            Label_PlayAudio.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 12F);
            Label_PlayAudio.Location = new System.Drawing.Point(16, 163);
            Label_PlayAudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label_PlayAudio.Name = "Label_PlayAudio";
            Label_PlayAudio.Size = new System.Drawing.Size(105, 21);
            Label_PlayAudio.TabIndex = 10;
            Label_PlayAudio.Text = "Play Audio?";
            // 
            // Check_PlayAudio
            // 
            Check_PlayAudio.AutoSize = true;
            Check_PlayAudio.Location = new System.Drawing.Point(172, 163);
            Check_PlayAudio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Check_PlayAudio.Name = "Check_PlayAudio";
            Check_PlayAudio.Size = new System.Drawing.Size(15, 14);
            Check_PlayAudio.TabIndex = 11;
            Check_PlayAudio.UseVisualStyleBackColor = true;
            // 
            // Panel_SaveControls
            // 
            Panel_SaveControls.BackColor = System.Drawing.SystemColors.ControlDark;
            Panel_SaveControls.Controls.Add(Button_Save);
            Panel_SaveControls.Location = new System.Drawing.Point(0, 213);
            Panel_SaveControls.Name = "Panel_SaveControls";
            Panel_SaveControls.Size = new System.Drawing.Size(380, 47);
            Panel_SaveControls.TabIndex = 12;
            // 
            // Form_Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClientSize = new System.Drawing.Size(380, 260);
            Controls.Add(Panel_SaveControls);
            Controls.Add(Check_PlayAudio);
            Controls.Add(Label_PlayAudio);
            Controls.Add(Text_ServerURL);
            Controls.Add(Label_ServerURL);
            Controls.Add(Text_WiiNo);
            Controls.Add(Text_DiscordID);
            Controls.Add(Label_DiscordID);
            Controls.Add(Combo_WiiType);
            Controls.Add(Label_WiiType);
            Controls.Add(Label_WiiNo);
            Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form_Settings";
            Text = "Settings";
            Load += Form_Settings_Load;
            Panel_SaveControls.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Label Label_WiiNo;
        private System.Windows.Forms.Label Label_WiiType;
        private System.Windows.Forms.ComboBox Combo_WiiType;
        private System.Windows.Forms.Label Label_DiscordID;
        private System.Windows.Forms.TextBox Text_DiscordID;
        private System.Windows.Forms.MaskedTextBox Text_WiiNo;
        private System.Windows.Forms.Label Label_ServerURL;
        private System.Windows.Forms.TextBox Text_ServerURL;
        private System.Windows.Forms.Label Label_PlayAudio;
        private System.Windows.Forms.CheckBox Check_PlayAudio;
        private System.Windows.Forms.Panel Panel_SaveControls;
    }
}
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
            this.Button_Save = new System.Windows.Forms.Button();
            this.Label_WiiNo = new System.Windows.Forms.Label();
            this.Label_WiiType = new System.Windows.Forms.Label();
            this.Combo_WiiType = new System.Windows.Forms.ComboBox();
            this.Label_DiscordID = new System.Windows.Forms.Label();
            this.Text_DiscordID = new System.Windows.Forms.TextBox();
            this.Text_WiiNo = new System.Windows.Forms.MaskedTextBox();
            this.Label_ServerURL = new System.Windows.Forms.Label();
            this.Text_ServerURL = new System.Windows.Forms.TextBox();
            this.Label_PlayAudio = new System.Windows.Forms.Label();
            this.Check_PlayAudio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(199, 189);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 23);
            this.Button_Save.TabIndex = 0;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_WiiNo
            // 
            this.Label_WiiNo.AutoSize = true;
            this.Label_WiiNo.Location = new System.Drawing.Point(38, 53);
            this.Label_WiiNo.Name = "Label_WiiNo";
            this.Label_WiiNo.Size = new System.Drawing.Size(36, 13);
            this.Label_WiiNo.TabIndex = 1;
            this.Label_WiiNo.Text = "WiiNo";
            // 
            // Label_WiiType
            // 
            this.Label_WiiType.AutoSize = true;
            this.Label_WiiType.Location = new System.Drawing.Point(38, 89);
            this.Label_WiiType.Name = "Label_WiiType";
            this.Label_WiiType.Size = new System.Drawing.Size(46, 13);
            this.Label_WiiType.TabIndex = 3;
            this.Label_WiiType.Text = "WiiType";
            // 
            // Combo_WiiType
            // 
            this.Combo_WiiType.FormattingEnabled = true;
            this.Combo_WiiType.Items.AddRange(new object[] {
            "Wii",
            "Wii U",
            "Dolphin"});
            this.Combo_WiiType.Location = new System.Drawing.Point(114, 81);
            this.Combo_WiiType.Name = "Combo_WiiType";
            this.Combo_WiiType.Size = new System.Drawing.Size(160, 21);
            this.Combo_WiiType.TabIndex = 4;
            this.Combo_WiiType.Text = "Select an item";
            // 
            // Label_DiscordID
            // 
            this.Label_DiscordID.AutoSize = true;
            this.Label_DiscordID.Location = new System.Drawing.Point(38, 124);
            this.Label_DiscordID.Name = "Label_DiscordID";
            this.Label_DiscordID.Size = new System.Drawing.Size(54, 13);
            this.Label_DiscordID.TabIndex = 5;
            this.Label_DiscordID.Text = "DiscordID";
            // 
            // Text_DiscordID
            // 
            this.Text_DiscordID.Location = new System.Drawing.Point(114, 117);
            this.Text_DiscordID.Name = "Text_DiscordID";
            this.Text_DiscordID.Size = new System.Drawing.Size(160, 20);
            this.Text_DiscordID.TabIndex = 6;
            // 
            // Text_WiiNo
            // 
            this.Text_WiiNo.Location = new System.Drawing.Point(114, 46);
            this.Text_WiiNo.Mask = "0000 0000 0000 0000";
            this.Text_WiiNo.Name = "Text_WiiNo";
            this.Text_WiiNo.Size = new System.Drawing.Size(160, 20);
            this.Text_WiiNo.TabIndex = 7;
            // 
            // Label_ServerURL
            // 
            this.Label_ServerURL.AutoSize = true;
            this.Label_ServerURL.Location = new System.Drawing.Point(38, 161);
            this.Label_ServerURL.Name = "Label_ServerURL";
            this.Label_ServerURL.Size = new System.Drawing.Size(60, 13);
            this.Label_ServerURL.TabIndex = 8;
            this.Label_ServerURL.Text = "ServerURL";
            // 
            // Text_ServerURL
            // 
            this.Text_ServerURL.Location = new System.Drawing.Point(114, 154);
            this.Text_ServerURL.Name = "Text_ServerURL";
            this.Text_ServerURL.Size = new System.Drawing.Size(160, 20);
            this.Text_ServerURL.TabIndex = 9;
            // 
            // Label_PlayAudio
            // 
            this.Label_PlayAudio.AutoSize = true;
            this.Label_PlayAudio.Location = new System.Drawing.Point(38, 194);
            this.Label_PlayAudio.Name = "Label_PlayAudio";
            this.Label_PlayAudio.Size = new System.Drawing.Size(54, 13);
            this.Label_PlayAudio.TabIndex = 10;
            this.Label_PlayAudio.Text = "PlayAudio";
            // 
            // Check_PlayAudio
            // 
            this.Check_PlayAudio.AutoSize = true;
            this.Check_PlayAudio.Location = new System.Drawing.Point(114, 193);
            this.Check_PlayAudio.Name = "Check_PlayAudio";
            this.Check_PlayAudio.Size = new System.Drawing.Size(15, 14);
            this.Check_PlayAudio.TabIndex = 11;
            this.Check_PlayAudio.UseVisualStyleBackColor = true;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Check_PlayAudio);
            this.Controls.Add(this.Label_PlayAudio);
            this.Controls.Add(this.Text_ServerURL);
            this.Controls.Add(this.Label_ServerURL);
            this.Controls.Add(this.Text_WiiNo);
            this.Controls.Add(this.Text_DiscordID);
            this.Controls.Add(this.Label_DiscordID);
            this.Controls.Add(this.Combo_WiiType);
            this.Controls.Add(this.Label_WiiType);
            this.Controls.Add(this.Label_WiiNo);
            this.Controls.Add(this.Button_Save);
            this.Name = "Form_Settings";
            this.Text = "Form_Settings";
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
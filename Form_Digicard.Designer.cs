namespace WiiLink_Desktop_CS
{
    partial class Form_Digicard
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
            Panel_Control = new System.Windows.Forms.Panel();
            Label_ID = new System.Windows.Forms.Label();
            Link_CardSite = new System.Windows.Forms.LinkLabel();
            Button_Close = new System.Windows.Forms.Button();
            Pic_Card = new System.Windows.Forms.PictureBox();
            Panel_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Card).BeginInit();
            SuspendLayout();
            // 
            // Panel_Control
            // 
            Panel_Control.BackColor = System.Drawing.SystemColors.ControlDark;
            Panel_Control.Controls.Add(Label_ID);
            Panel_Control.Controls.Add(Link_CardSite);
            Panel_Control.Controls.Add(Button_Close);
            Panel_Control.Location = new System.Drawing.Point(0, 232);
            Panel_Control.Name = "Panel_Control";
            Panel_Control.Size = new System.Drawing.Size(380, 48);
            Panel_Control.TabIndex = 0;
            // 
            // Label_ID
            // 
            Label_ID.AutoSize = true;
            Label_ID.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 6F);
            Label_ID.Location = new System.Drawing.Point(8, 28);
            Label_ID.Name = "Label_ID";
            Label_ID.Size = new System.Drawing.Size(52, 10);
            Label_ID.TabIndex = 2;
            Label_ID.Text = "Discord ID: ";
            // 
            // Link_CardSite
            // 
            Link_CardSite.AutoSize = true;
            Link_CardSite.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 9.7F);
            Link_CardSite.Location = new System.Drawing.Point(8, 8);
            Link_CardSite.Name = "Link_CardSite";
            Link_CardSite.Size = new System.Drawing.Size(178, 17);
            Link_CardSite.TabIndex = 1;
            Link_CardSite.TabStop = true;
            Link_CardSite.Text = "https://card.wiilink24.com/";
            // 
            // Button_Close
            // 
            Button_Close.BackColor = System.Drawing.SystemColors.Control;
            Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Button_Close.Font = new System.Drawing.Font("nintendo_NTLG-DB_002", 10F);
            Button_Close.Location = new System.Drawing.Point(201, 5);
            Button_Close.Name = "Button_Close";
            Button_Close.Size = new System.Drawing.Size(175, 38);
            Button_Close.TabIndex = 0;
            Button_Close.Text = "Close";
            Button_Close.UseVisualStyleBackColor = false;
            Button_Close.Click += Button_Close_Click;
            // 
            // Pic_Card
            // 
            Pic_Card.BackgroundImage = Properties.Resources.Regional_Poster;
            Pic_Card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Pic_Card.Location = new System.Drawing.Point(0, 0);
            Pic_Card.Name = "Pic_Card";
            Pic_Card.Size = new System.Drawing.Size(380, 233);
            Pic_Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Pic_Card.TabIndex = 1;
            Pic_Card.TabStop = false;
            // 
            // Form_Digicard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, 280);
            Controls.Add(Pic_Card);
            Controls.Add(Panel_Control);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form_Digicard";
            Text = "Digicard";
            Load += Form_Digicard_Load;
            Panel_Control.ResumeLayout(false);
            Panel_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Card).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Panel_Control;
        private System.Windows.Forms.LinkLabel Link_CardSite;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.PictureBox Pic_Card;
    }
}
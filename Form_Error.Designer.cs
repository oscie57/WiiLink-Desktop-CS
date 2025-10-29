namespace WiiLink_Desktop_CS
{
    partial class Form_Error
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
            label_title = new System.Windows.Forms.Label();
            label_desc = new System.Windows.Forms.Label();
            label_debug_title = new System.Windows.Forms.Label();
            label_debug_text = new System.Windows.Forms.Label();
            button_copy_debug = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_title.Location = new System.Drawing.Point(64, 25);
            label_title.Name = "label_title";
            label_title.Size = new System.Drawing.Size(262, 32);
            label_title.TabIndex = 0;
            label_title.Text = "An error has occured.";
            label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_desc
            // 
            label_desc.AutoSize = true;
            label_desc.Location = new System.Drawing.Point(23, 74);
            label_desc.Name = "label_desc";
            label_desc.Size = new System.Drawing.Size(338, 45);
            label_desc.TabIndex = 1;
            label_desc.Text = "The service may be under maintenance,\r\nor a server change has stopped the program from working.\r\nPlease report this to @splash.plus in the WiiLink Discord server.";
            label_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_debug_title
            // 
            label_debug_title.AutoSize = true;
            label_debug_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_debug_title.Location = new System.Drawing.Point(23, 142);
            label_debug_title.Name = "label_debug_title";
            label_debug_title.Size = new System.Drawing.Size(70, 15);
            label_debug_title.TabIndex = 2;
            label_debug_title.Text = "Debug Info";
            // 
            // label_debug_text
            // 
            label_debug_text.AutoSize = true;
            label_debug_text.Location = new System.Drawing.Point(23, 167);
            label_debug_text.Name = "label_debug_text";
            label_debug_text.Size = new System.Drawing.Size(62, 15);
            label_debug_text.TabIndex = 3;
            label_debug_text.Text = "Loading ...";
            // 
            // button_copy_debug
            // 
            button_copy_debug.Location = new System.Drawing.Point(286, 138);
            button_copy_debug.Name = "button_copy_debug";
            button_copy_debug.Size = new System.Drawing.Size(75, 23);
            button_copy_debug.TabIndex = 4;
            button_copy_debug.Text = "Copy";
            button_copy_debug.UseVisualStyleBackColor = true;
            // 
            // Form_Error
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Info;
            ClientSize = new System.Drawing.Size(384, 261);
            Controls.Add(button_copy_debug);
            Controls.Add(label_debug_text);
            Controls.Add(label_debug_title);
            Controls.Add(label_desc);
            Controls.Add(label_title);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form_Error";
            Text = "Error Occurred";
            Load += Form_Error_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.Label label_debug_title;
        private System.Windows.Forms.Label label_debug_text;
        private System.Windows.Forms.Button button_copy_debug;
    }
}
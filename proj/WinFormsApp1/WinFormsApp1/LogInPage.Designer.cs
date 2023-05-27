namespace First_page
{
    partial class LogInPage
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
            this.LogInBtn = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.RePassLabel = new System.Windows.Forms.Label();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.LightCoral;
            this.LogInBtn.ForeColor = System.Drawing.Color.White;
            this.LogInBtn.Location = new System.Drawing.Point(83, 176);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(134, 33);
            this.LogInBtn.TabIndex = 27;
            this.LogInBtn.Text = "Log in";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(13, 129);
            this.PassBox.Margin = new System.Windows.Forms.Padding(4);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(260, 23);
            this.PassBox.TabIndex = 23;
            // 
            // RePassLabel
            // 
            this.RePassLabel.AutoSize = true;
            this.RePassLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RePassLabel.Location = new System.Drawing.Point(13, 110);
            this.RePassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RePassLabel.Name = "RePassLabel";
            this.RePassLabel.Size = new System.Drawing.Size(57, 15);
            this.RePassLabel.TabIndex = 22;
            this.RePassLabel.Text = "Password";
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(13, 68);
            this.MailBox.Margin = new System.Windows.Forms.Padding(4);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(260, 23);
            this.MailBox.TabIndex = 20;
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LogInLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogInLabel.Location = new System.Drawing.Point(13, 9);
            this.LogInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(75, 30);
            this.LogInLabel.TabIndex = 18;
            this.LogInLabel.Text = "Log in";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MailLabel.Location = new System.Drawing.Point(13, 49);
            this.MailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(41, 15);
            this.MailLabel.TabIndex = 28;
            this.MailLabel.Text = "E-Mail";
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(289, 233);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.RePassLabel);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.LogInLabel);
            this.MaximumSize = new System.Drawing.Size(305, 272);
            this.MinimumSize = new System.Drawing.Size(305, 272);
            this.Name = "LogInPage";
            this.Text = "LogInPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LogInBtn;
        private TextBox PassBox;
        private Label RePassLabel;
        private TextBox MailBox;
        private Label LogInLabel;
        private Label MailLabel;
    }
}
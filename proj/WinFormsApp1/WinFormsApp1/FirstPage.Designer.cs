namespace WinFormsApp1
{
     partial class First
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            this.RegisterSide = new System.Windows.Forms.GroupBox();
            this.registerpanel = new System.Windows.Forms.TableLayoutPanel();
            this.LogIn = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GuestSide = new System.Windows.Forms.GroupBox();
            this.guestpanel = new System.Windows.Forms.TableLayoutPanel();
            this.GusetLabel = new System.Windows.Forms.Label();
            this.GuestBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RegisterSide.SuspendLayout();
            this.registerpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GuestSide.SuspendLayout();
            this.guestpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterSide
            // 
            this.RegisterSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterSide.BackColor = System.Drawing.Color.RosyBrown;
            this.RegisterSide.Controls.Add(this.registerpanel);
            this.RegisterSide.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterSide.Location = new System.Drawing.Point(20, 54);
            this.RegisterSide.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.RegisterSide.Name = "RegisterSide";
            this.RegisterSide.Size = new System.Drawing.Size(944, 160);
            this.RegisterSide.TabIndex = 0;
            this.RegisterSide.TabStop = false;
            this.RegisterSide.Text = "Register / login";
            // 
            // registerpanel
            // 
            this.registerpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerpanel.BackColor = System.Drawing.Color.DimGray;
            this.registerpanel.ColumnCount = 3;
            this.registerpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.11655F));
            this.registerpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.88345F));
            this.registerpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.registerpanel.Controls.Add(this.LogIn, 1, 0);
            this.registerpanel.Controls.Add(this.Register, 0, 0);
            this.registerpanel.Controls.Add(this.RegisterLabel, 2, 0);
            this.registerpanel.Location = new System.Drawing.Point(26, 24);
            this.registerpanel.Name = "registerpanel";
            this.registerpanel.RowCount = 1;
            this.registerpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.registerpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.registerpanel.Size = new System.Drawing.Size(872, 100);
            this.registerpanel.TabIndex = 3;
            // 
            // LogIn
            // 
            this.LogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogIn.BackColor = System.Drawing.Color.LightCoral;
            this.LogIn.Location = new System.Drawing.Point(363, 30);
            this.LogIn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(332, 40);
            this.LogIn.TabIndex = 5;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Register
            // 
            this.Register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Register.BackColor = System.Drawing.Color.LightCoral;
            this.Register.Location = new System.Drawing.Point(10, 30);
            this.Register.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(333, 40);
            this.Register.TabIndex = 4;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterLabel.Location = new System.Drawing.Point(720, 20);
            this.RegisterLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(136, 60);
            this.RegisterLabel.TabIndex = 2;
            this.RegisterLabel.Text = "Register and login to get unlimited re-rolls, plus more profile costomisation.";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RegisterSide, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GuestSide, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 536);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // GuestSide
            // 
            this.GuestSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GuestSide.BackColor = System.Drawing.Color.RosyBrown;
            this.GuestSide.Controls.Add(this.guestpanel);
            this.GuestSide.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestSide.Location = new System.Drawing.Point(20, 322);
            this.GuestSide.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.GuestSide.Name = "GuestSide";
            this.GuestSide.Size = new System.Drawing.Size(944, 160);
            this.GuestSide.TabIndex = 3;
            this.GuestSide.TabStop = false;
            this.GuestSide.Text = "Continiue as Guest";
            // 
            // guestpanel
            // 
            this.guestpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guestpanel.BackColor = System.Drawing.Color.DimGray;
            this.guestpanel.ColumnCount = 2;
            this.guestpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.guestpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.guestpanel.Controls.Add(this.GusetLabel, 1, 0);
            this.guestpanel.Controls.Add(this.GuestBtn, 0, 0);
            this.guestpanel.Location = new System.Drawing.Point(26, 24);
            this.guestpanel.Name = "guestpanel";
            this.guestpanel.RowCount = 1;
            this.guestpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.guestpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.guestpanel.Size = new System.Drawing.Size(872, 100);
            this.guestpanel.TabIndex = 3;
            // 
            // GusetLabel
            // 
            this.GusetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GusetLabel.AutoSize = true;
            this.GusetLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GusetLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GusetLabel.Location = new System.Drawing.Point(447, 35);
            this.GusetLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.GusetLabel.Name = "GusetLabel";
            this.GusetLabel.Size = new System.Drawing.Size(414, 30);
            this.GusetLabel.TabIndex = 2;
            this.GusetLabel.Text = "Get to descover some new movies fast , but with added limit of 30 re-rolls per 1h" +
    ".";
            this.GusetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuestBtn
            // 
            this.GuestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GuestBtn.BackColor = System.Drawing.Color.LightCoral;
            this.GuestBtn.Location = new System.Drawing.Point(15, 30);
            this.GuestBtn.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.GuestBtn.Name = "GuestBtn";
            this.GuestBtn.Size = new System.Drawing.Size(406, 40);
            this.GuestBtn.TabIndex = 3;
            this.GuestBtn.Text = "Start now";
            this.GuestBtn.UseVisualStyleBackColor = false;
            this.GuestBtn.Click += new System.EventHandler(this.GuestBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(249, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "register/login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 90);
            this.label2.TabIndex = 2;
            this.label2.Text = "get to descover some new movies fast , but with added limit of 30 re-rolls per 1h" +
    ".";
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1008, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(540, 410);
            this.Name = "First";
            this.Text = "first page";
            this.RegisterSide.ResumeLayout(false);
            this.registerpanel.ResumeLayout(false);
            this.registerpanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GuestSide.ResumeLayout(false);
            this.guestpanel.ResumeLayout(false);
            this.guestpanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox RegisterSide;
        private TableLayoutPanel registerpanel;
        private Label RegisterLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox GuestSide;
        private TableLayoutPanel guestpanel;
        private Label GusetLabel;
        private GroupBox groupBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Button LogIn;
        private Button Register;
        private Button GuestBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
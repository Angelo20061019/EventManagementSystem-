namespace Event_MS.GUIs
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            linkGoBack = new LinkLabel();
            txtAdminID = new TextBox();
            label5 = new Label();
            txtAdminTP = new TextBox();
            label4 = new Label();
            txtAdminEmail = new TextBox();
            label3 = new Label();
            btnResetAdmin = new Button();
            btnSignAdmin = new Button();
            txtAdminPassword = new TextBox();
            label2 = new Label();
            txtAdminName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkGoBack
            // 
            linkGoBack.ActiveLinkColor = SystemColors.ActiveCaption;
            linkGoBack.AutoSize = true;
            linkGoBack.Font = new Font("SimSun", 9F, FontStyle.Bold);
            linkGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            linkGoBack.LinkColor = Color.FromArgb(236, 223, 204);
            linkGoBack.Location = new Point(41, 1061);
            linkGoBack.Name = "linkGoBack";
            linkGoBack.Size = new Size(140, 24);
            linkGoBack.TabIndex = 36;
            linkGoBack.TabStop = true;
            linkGoBack.Text = "<< Go Back";
            linkGoBack.LinkClicked += linkGoBack_LinkClicked;
            // 
            // txtAdminID
            // 
            txtAdminID.BackColor = Color.FromArgb(105, 117, 101);
            txtAdminID.BorderStyle = BorderStyle.None;
            txtAdminID.ForeColor = Color.FromArgb(236, 223, 204);
            txtAdminID.Location = new Point(797, 523);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(476, 32);
            txtAdminID.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(236, 223, 204);
            label5.Location = new Point(534, 517);
            label5.Name = "label5";
            label5.Size = new Size(117, 38);
            label5.TabIndex = 34;
            label5.Text = "ID : ";
            // 
            // txtAdminTP
            // 
            txtAdminTP.BackColor = Color.FromArgb(105, 117, 101);
            txtAdminTP.BorderStyle = BorderStyle.None;
            txtAdminTP.ForeColor = Color.FromArgb(236, 223, 204);
            txtAdminTP.Location = new Point(797, 809);
            txtAdminTP.Name = "txtAdminTP";
            txtAdminTP.Size = new Size(476, 32);
            txtAdminTP.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(236, 223, 204);
            label4.Location = new Point(534, 803);
            label4.Name = "label4";
            label4.Size = new Size(257, 38);
            label4.TabIndex = 32;
            label4.Text = "Contact No :";
            // 
            // txtAdminEmail
            // 
            txtAdminEmail.BackColor = Color.FromArgb(105, 117, 101);
            txtAdminEmail.BorderStyle = BorderStyle.None;
            txtAdminEmail.ForeColor = Color.FromArgb(236, 223, 204);
            txtAdminEmail.Location = new Point(797, 738);
            txtAdminEmail.Name = "txtAdminEmail";
            txtAdminEmail.Size = new Size(476, 32);
            txtAdminEmail.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(236, 223, 204);
            label3.Location = new Point(534, 732);
            label3.Name = "label3";
            label3.Size = new Size(177, 38);
            label3.TabIndex = 30;
            label3.Text = "Email : ";
            // 
            // btnResetAdmin
            // 
            btnResetAdmin.BackColor = Color.FromArgb(60, 61, 55);
            btnResetAdmin.FlatStyle = FlatStyle.Popup;
            btnResetAdmin.Font = new Font("SimSun", 12F, FontStyle.Bold);
            btnResetAdmin.ForeColor = Color.FromArgb(236, 223, 204);
            btnResetAdmin.Location = new Point(954, 965);
            btnResetAdmin.Name = "btnResetAdmin";
            btnResetAdmin.Size = new Size(214, 63);
            btnResetAdmin.TabIndex = 29;
            btnResetAdmin.Text = "Reset";
            btnResetAdmin.UseVisualStyleBackColor = false;
            btnResetAdmin.Click += btnResetAdmin_Click;
            // 
            // btnSignAdmin
            // 
            btnSignAdmin.BackColor = Color.FromArgb(60, 61, 55);
            btnSignAdmin.FlatStyle = FlatStyle.Popup;
            btnSignAdmin.Font = new Font("SimSun", 12F, FontStyle.Bold);
            btnSignAdmin.ForeColor = Color.FromArgb(236, 223, 204);
            btnSignAdmin.Location = new Point(624, 965);
            btnSignAdmin.Name = "btnSignAdmin";
            btnSignAdmin.Size = new Size(214, 63);
            btnSignAdmin.TabIndex = 28;
            btnSignAdmin.Text = "Sign In";
            btnSignAdmin.UseVisualStyleBackColor = false;
            btnSignAdmin.Click += btnSignAdmin_Click;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BackColor = Color.FromArgb(105, 117, 101);
            txtAdminPassword.BorderStyle = BorderStyle.None;
            txtAdminPassword.ForeColor = Color.FromArgb(236, 223, 204);
            txtAdminPassword.Location = new Point(797, 661);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.Size = new Size(476, 32);
            txtAdminPassword.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(236, 223, 204);
            label2.Location = new Point(534, 655);
            label2.Name = "label2";
            label2.Size = new Size(237, 38);
            label2.TabIndex = 26;
            label2.Text = "Password : ";
            // 
            // txtAdminName
            // 
            txtAdminName.BackColor = Color.FromArgb(105, 117, 101);
            txtAdminName.BorderStyle = BorderStyle.None;
            txtAdminName.ForeColor = Color.FromArgb(236, 223, 204);
            txtAdminName.Location = new Point(797, 594);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(476, 32);
            txtAdminName.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(236, 223, 204);
            label1.Location = new Point(534, 594);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 24;
            label1.Text = "Name : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(710, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 30);
            ClientSize = new Size(1800, 1100);
            Controls.Add(linkGoBack);
            Controls.Add(txtAdminID);
            Controls.Add(label5);
            Controls.Add(txtAdminTP);
            Controls.Add(label4);
            Controls.Add(txtAdminEmail);
            Controls.Add(label3);
            Controls.Add(btnResetAdmin);
            Controls.Add(btnSignAdmin);
            Controls.Add(txtAdminPassword);
            Controls.Add(label2);
            Controls.Add(txtAdminName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkGoBack;
        private TextBox txtAdminID;
        private Label label5;
        private TextBox txtAdminTP;
        private Label label4;
        private TextBox txtAdminEmail;
        private Label label3;
        private Button btnResetAdmin;
        private Button btnSignAdmin;
        private TextBox txtAdminPassword;
        private Label label2;
        private TextBox txtAdminName;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
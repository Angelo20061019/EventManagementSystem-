namespace Event_MS.GUIs
{
    partial class LoginMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMember));
            btnResetMember = new Button();
            btnSignMember = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkGoBack = new LinkLabel();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtMemberPassword = new TextBox();
            txtMemberEmail = new TextBox();
            txtMemberTP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnResetMember
            // 
            btnResetMember.BackColor = Color.FromArgb(60, 61, 55);
            btnResetMember.FlatStyle = FlatStyle.Popup;
            btnResetMember.Font = new Font("SimSun", 12F, FontStyle.Bold);
            btnResetMember.ForeColor = Color.FromArgb(236, 223, 204);
            btnResetMember.Location = new Point(962, 962);
            btnResetMember.Name = "btnResetMember";
            btnResetMember.Size = new Size(214, 63);
            btnResetMember.TabIndex = 15;
            btnResetMember.Text = "Reset";
            btnResetMember.UseVisualStyleBackColor = false;
            //btnResetMember.Click += btnResetMember_Click;
            // 
            // btnSignMember
            // 
            btnSignMember.BackColor = Color.FromArgb(60, 61, 55);
            btnSignMember.FlatStyle = FlatStyle.Popup;
            btnSignMember.Font = new Font("SimSun", 12F, FontStyle.Bold);
            btnSignMember.ForeColor = Color.FromArgb(236, 223, 204);
            btnSignMember.Location = new Point(632, 962);
            btnSignMember.Name = "btnSignMember";
            btnSignMember.Size = new Size(214, 63);
            btnSignMember.TabIndex = 14;
            btnSignMember.Text = "Sign In";
            btnSignMember.UseVisualStyleBackColor = false;
            btnSignMember.Click += btnSignMember_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(236, 223, 204);
            label2.Location = new Point(542, 652);
            label2.Name = "label2";
            label2.Size = new Size(237, 38);
            label2.TabIndex = 11;
            label2.Text = "Password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(236, 223, 204);
            label1.Location = new Point(542, 591);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 9;
            label1.Text = "Name : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(718, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(236, 223, 204);
            label3.Location = new Point(542, 729);
            label3.Name = "label3";
            label3.Size = new Size(177, 38);
            label3.TabIndex = 16;
            label3.Text = "Email : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(236, 223, 204);
            label4.Location = new Point(542, 800);
            label4.Name = "label4";
            label4.Size = new Size(257, 38);
            label4.TabIndex = 18;
            label4.Text = "Contact No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(236, 223, 204);
            label5.Location = new Point(542, 514);
            label5.Name = "label5";
            label5.Size = new Size(117, 38);
            label5.TabIndex = 20;
            label5.Text = "ID : ";
            // 
            // linkGoBack
            // 
            linkGoBack.ActiveLinkColor = SystemColors.ActiveCaption;
            linkGoBack.AutoSize = true;
            linkGoBack.Font = new Font("SimSun", 9F, FontStyle.Bold);
            linkGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            linkGoBack.LinkColor = Color.FromArgb(236, 223, 204);
            linkGoBack.Location = new Point(49, 1058);
            linkGoBack.Name = "linkGoBack";
            linkGoBack.Size = new Size(140, 24);
            linkGoBack.TabIndex = 22;
            linkGoBack.TabStop = true;
            linkGoBack.Text = "<< Go Back";
            // 
            // txtMemberID
            // 
            txtMemberID.BackColor = Color.FromArgb(105, 117, 101);
            txtMemberID.BorderStyle = BorderStyle.None;
            txtMemberID.ForeColor = Color.FromArgb(236, 223, 204);
            txtMemberID.Location = new Point(795, 514);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(476, 32);
            txtMemberID.TabIndex = 36;
            // 
            // txtMemberName
            // 
            txtMemberName.BackColor = Color.FromArgb(105, 117, 101);
            txtMemberName.BorderStyle = BorderStyle.None;
            txtMemberName.ForeColor = Color.FromArgb(236, 223, 204);
            txtMemberName.Location = new Point(795, 591);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(476, 32);
            txtMemberName.TabIndex = 37;
            // 
            // txtMemberPassword
            // 
            txtMemberPassword.BackColor = Color.FromArgb(105, 117, 101);
            txtMemberPassword.BorderStyle = BorderStyle.None;
            txtMemberPassword.ForeColor = Color.FromArgb(236, 223, 204);
            txtMemberPassword.Location = new Point(795, 658);
            txtMemberPassword.Name = "txtMemberPassword";
            txtMemberPassword.Size = new Size(476, 32);
            txtMemberPassword.TabIndex = 38;
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.BackColor = Color.FromArgb(105, 117, 101);
            txtMemberEmail.BorderStyle = BorderStyle.None;
            txtMemberEmail.ForeColor = Color.FromArgb(236, 223, 204);
            txtMemberEmail.Location = new Point(795, 729);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(476, 32);
            txtMemberEmail.TabIndex = 39;
            // 
            // txtMemberTP
            // 
            txtMemberTP.BackColor = Color.FromArgb(105, 117, 101);
            txtMemberTP.BorderStyle = BorderStyle.None;
            txtMemberTP.ForeColor = Color.FromArgb(236, 223, 204);
            txtMemberTP.Location = new Point(795, 800);
            txtMemberTP.Name = "txtMemberTP";
            txtMemberTP.Size = new Size(476, 32);
            txtMemberTP.TabIndex = 40;
            // 
            // LoginMember
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 30);
            ClientSize = new Size(1800, 1100);
            Controls.Add(txtMemberTP);
            Controls.Add(txtMemberEmail);
            Controls.Add(txtMemberPassword);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(linkGoBack);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnResetMember);
            Controls.Add(btnSignMember);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginMember";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResetMember;
        private Button btnSignMember;
        private TextBox txtMPassword;
        private Label label2;
        private TextBox txtMName;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtMEmail;
        private Label label3;
        private TextBox txtMTP;
        private Label label4;
        private TextBox txtMID;
        private Label label5;
        private LinkLabel linkGoBack;
        private TextBox MemberIDTXT;
        private TextBox MemberTPTextBox;
        private TextBox MemberEmailTextBox;
        private TextBox MemberPasswordTextBox;
        private TextBox MemberNameTextBox;
        private TextBox MemberIDTextBox;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtMemberPassword;
        private TextBox txtMemberEmail;
        private TextBox txtMemberTP;
    }
}
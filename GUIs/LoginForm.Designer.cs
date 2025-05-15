namespace Event_MS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            txtUName = new TextBox();
            txtUPassword = new TextBox();
            linkMemberSignin = new LinkLabel();
            btnLogin = new Button();
            btnReset = new Button();
            radiobtnAmin = new RadioButton();
            radiobtnMember = new RadioButton();
            showPW = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(690, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUName
            // 
            txtUName.BackColor = Color.FromArgb(105, 117, 101);
            txtUName.BorderStyle = BorderStyle.None;
            txtUName.ForeColor = Color.FromArgb(236, 223, 204);
            txtUName.Location = new Point(796, 560);
            txtUName.Name = "txtUName";
            txtUName.Size = new Size(476, 32);
            txtUName.TabIndex = 2;
            // 
            // txtUPassword
            // 
            txtUPassword.BackColor = Color.FromArgb(105, 117, 101);
            txtUPassword.BorderStyle = BorderStyle.None;
            txtUPassword.ForeColor = Color.FromArgb(236, 223, 204);
            txtUPassword.Location = new Point(796, 642);
            txtUPassword.Name = "txtUPassword";
            txtUPassword.Size = new Size(476, 32);
            txtUPassword.TabIndex = 4;
            txtUPassword.UseSystemPasswordChar = true;
            // 
            // linkMemberSignin
            // 
            linkMemberSignin.ActiveLinkColor = SystemColors.ActiveCaption;
            linkMemberSignin.AutoSize = true;
            linkMemberSignin.Font = new Font("SimSun", 9F, FontStyle.Bold);
            linkMemberSignin.LinkColor = Color.FromArgb(236, 223, 204);
            linkMemberSignin.Location = new Point(1094, 768);
            linkMemberSignin.Name = "linkMemberSignin";
            linkMemberSignin.Size = new Size(192, 24);
            linkMemberSignin.TabIndex = 5;
            linkMemberSignin.TabStop = true;
            linkMemberSignin.Text = "Member Sign in";
            linkMemberSignin.LinkClicked += linkMemberSignin_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(60, 61, 55);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("SimSun", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(236, 223, 204);
            btnLogin.Location = new Point(604, 904);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(214, 63);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(60, 61, 55);
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("SimSun", 12F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(236, 223, 204);
            btnReset.Location = new Point(922, 904);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(214, 63);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click_1;
            // 
            // radiobtnAmin
            // 
            radiobtnAmin.AutoSize = true;
            radiobtnAmin.Font = new Font("SimSun", 10F, FontStyle.Bold);
            radiobtnAmin.ForeColor = Color.FromArgb(236, 223, 204);
            radiobtnAmin.Location = new Point(732, 812);
            radiobtnAmin.Name = "radiobtnAmin";
            radiobtnAmin.Size = new Size(118, 31);
            radiobtnAmin.TabIndex = 8;
            radiobtnAmin.TabStop = true;
            radiobtnAmin.Text = "Admin";
            radiobtnAmin.UseVisualStyleBackColor = true;
            // 
            // radiobtnMember
            // 
            radiobtnMember.AutoSize = true;
            radiobtnMember.Font = new Font("SimSun", 10F, FontStyle.Bold);
            radiobtnMember.ForeColor = Color.FromArgb(236, 223, 204);
            radiobtnMember.Location = new Point(911, 812);
            radiobtnMember.Name = "radiobtnMember";
            radiobtnMember.Size = new Size(133, 31);
            radiobtnMember.TabIndex = 9;
            radiobtnMember.TabStop = true;
            radiobtnMember.Text = "Member";
            radiobtnMember.UseVisualStyleBackColor = true;
            // 
            // showPW
            // 
            showPW.AutoSize = true;
            showPW.Font = new Font("SimSun", 9F, FontStyle.Bold);
            showPW.ForeColor = Color.FromArgb(236, 223, 204);
            showPW.Location = new Point(1061, 703);
            showPW.Name = "showPW";
            showPW.Size = new Size(211, 28);
            showPW.TabIndex = 10;
            showPW.Text = "Show password";
            showPW.UseVisualStyleBackColor = true;
            showPW.CheckedChanged += showPW_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(236, 223, 204);
            label1.Location = new Point(563, 560);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 11;
            label1.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(236, 223, 204);
            label2.Location = new Point(553, 642);
            label2.Name = "label2";
            label2.Size = new Size(237, 38);
            label2.TabIndex = 12;
            label2.Text = "Password : ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 30);
            ClientSize = new Size(1800, 1100);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(showPW);
            Controls.Add(radiobtnMember);
            Controls.Add(radiobtnAmin);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(linkMemberSignin);
            Controls.Add(txtUPassword);
            Controls.Add(txtUName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUName;
        private TextBox txtUPassword;
        private LinkLabel linkMemberSignin;
        private Button btnLogin;
        private Button btnReset;
        private RadioButton radiobtnAmin;
        private RadioButton radiobtnMember;
        private CheckBox showPW;
        private Label label1;
        private Label label2;
    }
}
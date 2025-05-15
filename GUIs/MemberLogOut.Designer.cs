namespace Event_MS.GUIs
{
    partial class MemberLogOut
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
            label1 = new Label();
            button1 = new Button();
            btnMemberLogOut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(236, 223, 204);
            label1.Location = new Point(138, 99);
            label1.Name = "label1";
            label1.Size = new Size(423, 33);
            label1.TabIndex = 1;
            label1.Text = "Do you want to Log out ?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(60, 61, 55);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("SimSun", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(236, 223, 204);
            button1.Location = new Point(361, 172);
            button1.Name = "button1";
            button1.Size = new Size(159, 49);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMemberLogOut
            // 
            btnMemberLogOut.BackColor = Color.FromArgb(60, 61, 55);
            btnMemberLogOut.FlatStyle = FlatStyle.Popup;
            btnMemberLogOut.Font = new Font("SimSun", 9F, FontStyle.Bold);
            btnMemberLogOut.ForeColor = Color.FromArgb(236, 223, 204);
            btnMemberLogOut.Location = new Point(161, 172);
            btnMemberLogOut.Name = "btnMemberLogOut";
            btnMemberLogOut.Size = new Size(159, 49);
            btnMemberLogOut.TabIndex = 10;
            btnMemberLogOut.Text = "Log Out";
            btnMemberLogOut.UseVisualStyleBackColor = false;
            btnMemberLogOut.Click += btnMemberLogOut_Click;
            // 
            // MemberLogOut
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 30);
            ClientSize = new Size(680, 291);
            Controls.Add(button1);
            Controls.Add(btnMemberLogOut);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberLogOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberLogOut";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnMemberLogOut;
    }
}
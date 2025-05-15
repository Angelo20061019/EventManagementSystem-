namespace Event_MS.GUIs
{
    partial class AddEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvents));
            linkGoBack = new LinkLabel();
            txtEventID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnEventRset = new Button();
            btnEventAdd = new Button();
            txtEventTypeee = new TextBox();
            label2 = new Label();
            txtEventName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtEventVenue = new TextBox();
            txtEventTicket = new TextBox();
            txtEventTicketquantity = new TextBox();
            label6 = new Label();
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
            linkGoBack.Location = new Point(57, 1062);
            linkGoBack.Name = "linkGoBack";
            linkGoBack.Size = new Size(140, 24);
            linkGoBack.TabIndex = 50;
            linkGoBack.TabStop = true;
            linkGoBack.Text = "<< Go Back";
            linkGoBack.LinkClicked += linkGoBack_LinkClicked;
            // 
            // txtEventID
            // 
            txtEventID.BackColor = Color.FromArgb(105, 117, 101);
            txtEventID.BorderStyle = BorderStyle.None;
            txtEventID.ForeColor = Color.FromArgb(236, 223, 204);
            txtEventID.Location = new Point(844, 524);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(476, 32);
            txtEventID.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(550, 518);
            label5.Name = "label5";
            label5.Size = new Size(117, 38);
            label5.TabIndex = 48;
            label5.Text = "ID : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(236, 223, 204);
            label4.Location = new Point(550, 848);
            label4.Name = "label4";
            label4.Size = new Size(177, 38);
            label4.TabIndex = 46;
            label4.Text = "Ticket :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(236, 223, 204);
            label3.Location = new Point(550, 733);
            label3.Name = "label3";
            label3.Size = new Size(277, 38);
            label3.TabIndex = 44;
            label3.Text = "Event Venue :";
            // 
            // btnEventRset
            // 
            btnEventRset.BackColor = Color.FromArgb(60, 61, 55);
            btnEventRset.FlatStyle = FlatStyle.Popup;
            btnEventRset.Font = new Font("SimSun", 12F, FontStyle.Bold);
            btnEventRset.ForeColor = Color.FromArgb(236, 223, 204);
            btnEventRset.Location = new Point(970, 966);
            btnEventRset.Name = "btnEventRset";
            btnEventRset.Size = new Size(214, 63);
            btnEventRset.TabIndex = 43;
            btnEventRset.Text = "Reset";
            btnEventRset.UseVisualStyleBackColor = false;
            // 
            // btnEventAdd
            // 
            btnEventAdd.BackColor = Color.FromArgb(60, 61, 55);
            btnEventAdd.FlatStyle = FlatStyle.Popup;
            btnEventAdd.Font = new Font("SimSun", 12F, FontStyle.Bold);
            btnEventAdd.ForeColor = Color.FromArgb(236, 223, 204);
            btnEventAdd.Location = new Point(640, 966);
            btnEventAdd.Name = "btnEventAdd";
            btnEventAdd.Size = new Size(214, 63);
            btnEventAdd.TabIndex = 42;
            btnEventAdd.Text = "Add";
            btnEventAdd.UseVisualStyleBackColor = false;
            btnEventAdd.Click += btnEventAdd_Click;
            // 
            // txtEventTypeee
            // 
            txtEventTypeee.BackColor = Color.FromArgb(105, 117, 101);
            txtEventTypeee.BorderStyle = BorderStyle.None;
            txtEventTypeee.ForeColor = Color.FromArgb(236, 223, 204);
            txtEventTypeee.Location = new Point(844, 662);
            txtEventTypeee.Name = "txtEventTypeee";
            txtEventTypeee.Size = new Size(476, 32);
            txtEventTypeee.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(236, 223, 204);
            label2.Location = new Point(550, 656);
            label2.Name = "label2";
            label2.Size = new Size(257, 38);
            label2.TabIndex = 40;
            label2.Text = "Event Type :";
            // 
            // txtEventName
            // 
            txtEventName.BackColor = Color.FromArgb(105, 117, 101);
            txtEventName.BorderStyle = BorderStyle.None;
            txtEventName.ForeColor = Color.FromArgb(236, 223, 204);
            txtEventName.Location = new Point(844, 595);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(476, 32);
            txtEventName.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(236, 223, 204);
            label1.Location = new Point(550, 595);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 38;
            label1.Text = "Event Name : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(726, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // txtEventVenue
            // 
            txtEventVenue.BackColor = Color.FromArgb(105, 117, 101);
            txtEventVenue.BorderStyle = BorderStyle.None;
            txtEventVenue.ForeColor = Color.FromArgb(236, 223, 204);
            txtEventVenue.Location = new Point(844, 733);
            txtEventVenue.Name = "txtEventVenue";
            txtEventVenue.Size = new Size(476, 32);
            txtEventVenue.TabIndex = 51;
            // 
            // txtEventTicket
            // 
            txtEventTicket.BackColor = Color.FromArgb(105, 117, 101);
            txtEventTicket.BorderStyle = BorderStyle.None;
            txtEventTicket.ForeColor = Color.FromArgb(236, 223, 204);
            txtEventTicket.Location = new Point(844, 848);
            txtEventTicket.Name = "txtEventTicket";
            txtEventTicket.Size = new Size(476, 32);
            txtEventTicket.TabIndex = 52;
            // 
            // txtEventTicketquantity
            // 
            txtEventTicketquantity.BackColor = Color.FromArgb(105, 117, 101);
            txtEventTicketquantity.BorderStyle = BorderStyle.None;
            txtEventTicketquantity.ForeColor = Color.FromArgb(236, 223, 204);
            txtEventTicketquantity.Location = new Point(844, 793);
            txtEventTicketquantity.Name = "txtEventTicketquantity";
            txtEventTicketquantity.Size = new Size(476, 32);
            txtEventTicketquantity.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Font = new Font("SimSun", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(236, 223, 204);
            label6.Location = new Point(550, 793);
            label6.Name = "label6";
            label6.Size = new Size(297, 38);
            label6.TabIndex = 53;
            label6.Text = "Ticket price :";
            label6.Click += label6_Click;
            // 
            // AddEvents
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 30);
            ClientSize = new Size(1800, 1100);
            Controls.Add(txtEventTicketquantity);
            Controls.Add(label6);
            Controls.Add(txtEventTicket);
            Controls.Add(txtEventVenue);
            Controls.Add(linkGoBack);
            Controls.Add(txtEventID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEventRset);
            Controls.Add(btnEventAdd);
            Controls.Add(txtEventTypeee);
            Controls.Add(label2);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEvents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEvents";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkGoBack;
        private TextBox txtEventID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnEventRset;
        private Button btnEventAdd;
        private TextBox txtEventType;
        private Label label2;
        private TextBox txtEventName;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaatxtEventTicket;
        private TextBox txtEventVenue;
        private TextBox txtEventTicket;
        private TextBox txtEventTypeee;
        private TextBox txtEventTicketquantity;
        private Label label6;
    }
}
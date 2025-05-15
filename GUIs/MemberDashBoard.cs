using Event_MS.Classes;
using System.Runtime.InteropServices;

namespace Event_MS.GUIs
{
    public partial class MemberDashBoard : Form
    {
        private Participant member;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public MemberDashBoard(Participant member)
        {
            this.member = member;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnMemberEvents_Click(object sender, EventArgs e)
        {
            MemberEvents memberEvents = new MemberEvents(member);
            memberEvents.Show();
            this.Hide();
        }

        private void btnMemberBookings_Click(object sender, EventArgs e)
        {
            MemberBookings memberBookings = new MemberBookings(member);
            memberBookings.Show();
            this.Hide();
        }

        private void btnMemberLogOut_Click(object sender, EventArgs e)
        {
            MemberLogOut memberLogOut = new MemberLogOut(member);
            memberLogOut.Show();
            this.Hide();
        }
    }
}

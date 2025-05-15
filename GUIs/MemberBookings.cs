using Event_MS.Classes;
using System.Runtime.InteropServices;

namespace Event_MS.GUIs
{
    public partial class MemberBookings : Form
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
        public MemberBookings(Participant member)
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

        private void btnMemberHome_Click(object sender, EventArgs e)
        {
            MemberDashBoard memberDashBoard = new MemberDashBoard(member);
            memberDashBoard.Show();
            this.Hide();
        }

        private void btnMemberEvents_Click(object sender, EventArgs e)
        {
            MemberEvents memberEvents = new MemberEvents(member);
            memberEvents.Show();
            this.Hide();
        }

        private void btnMemberLogOut_Click(object sender, EventArgs e)
        {
            MemberLogOut memberLogOut = new MemberLogOut(member);
            memberLogOut.Show();
            this.Hide();
        }

        private void btnMemberBookings_Click(object sender, EventArgs e)
        {

        }

        private void MemberBookings_Load(object sender, EventArgs e)
        {
            LoadBookedEvents();
        }
        private void LoadBookedEvents()
        {
            string memberId = member.Id;
            List<Booking> events = Booking.AllBookedEvents(memberId);
            dgvEventBookingM.DataSource = events;
        }

        private void btnEventBook_Click(object sender, EventArgs e)
        {
            if (dgvEventBookingM.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }

            // Get the selected member's ID
            int selectedEventId = Convert.ToInt32(dgvEventBookingM.SelectedRows[0].Cells["bookingid"].Value);
            Booking.DeleteEventById(selectedEventId);


            // Refresh the member list after deletion
            LoadBookedEvents();

            MessageBox.Show("Event canceled successfully!");    
        }
    }
}

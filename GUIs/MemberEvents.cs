using Event_MS.Classes;
using System.Runtime.InteropServices;

namespace Event_MS.GUIs
{
    public partial class MemberEvents : Form
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
        public MemberEvents(Participant member)
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

        private void MemberEvents_Load(object sender, EventArgs e)
        {
            LoadEvents();

        }
        private void LoadEvents()
        {
            List<Organizer> manageEvents = Organizer.GetAllEvents();

            // Bind the members list to the DataGridView or ListView
            dgvEventM.DataSource = manageEvents;
        }

        private void btnEventBook_Click(object sender, EventArgs e)
        {
            if (dgvEventM.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event to book.");
                return;
            }

            // Get the selected event's details
            int selectedEventId = Convert.ToInt32(dgvEventM.SelectedRows[0].Cells["EventId"].Value);
            string eventName = dgvEventM.SelectedRows[0].Cells["EventName"].Value.ToString();
            string eventid = dgvEventM.SelectedRows[0].Cells["EventId"].Value.ToString();  // Assuming 'EventId' is used here as well

            // Make sure to extract the event type here
            string eventtype = dgvEventM.SelectedRows[0].Cells["EventType"].Value.ToString();

            // Assuming member has an Id property to identify the member
            string memberId = this.member.Id;

            // Pass the event details and member ID to the BookedEvents constructor
            Booking events = new Booking(selectedEventId.ToString(), eventid, eventName, eventtype, memberId);

            // Save the booked event
            events.BookEvent();

            LoadEvents();

        }
    }
}

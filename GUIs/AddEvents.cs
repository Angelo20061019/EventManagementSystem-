using Event_MS.Classes;
using System.Runtime.InteropServices;

namespace Event_MS.GUIs
{
    public partial class AddEvents : Form
    {
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
        public AddEvents()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void linkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminEvents adminEvents = new AdminEvents();
            adminEvents.Show();
            this.Hide();
        }

        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            string id = txtEventID.Text;
            string name = txtEventName.Text;
            string type = txtEventTypeee.Text;
            string venue = txtEventVenue.Text;
            string tickets = txtEventTicketquantity.Text;
            string ticketprice = txtEventTicket.Text;


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(type) ||
                string.IsNullOrEmpty(venue) || string.IsNullOrEmpty(ticketprice) || string.IsNullOrEmpty(tickets))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Organizer manageEvents = new Organizer(id, name, type, venue, tickets, ticketprice);
            Organizer.AddEvent(manageEvents);

            AdminEvents adminEvents = new AdminEvents();
            adminEvents.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

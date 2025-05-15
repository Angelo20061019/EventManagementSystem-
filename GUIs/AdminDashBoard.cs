using Event_MS.Classes;
using System.Runtime.InteropServices;

namespace Event_MS.GUIs
{
    public partial class AdminDashBoard : Form
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
        public AdminDashBoard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdminAdd_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
            this.Hide();
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

        private void btnAdminMember_Click(object sender, EventArgs e)
        {
            AdminMember adminMember = new AdminMember();
            adminMember.Show();
            this.Hide();
        }

        private void btnAdminEvents_Click(object sender, EventArgs e)
        {
            AdminEvents adminEvents = new AdminEvents();
            adminEvents.Show();
            this.Hide();
        }

        private void btnAdminLogOut_Click(object sender, EventArgs e)
        {
            AdminLogOut adminLogOut = new AdminLogOut();
            adminLogOut.Show();
            this.Hide();
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a admin to delete.");
                return;
            }

            // Get the selected member's ID
            int selectedAdminId = Convert.ToInt32(dgvAdmin.SelectedRows[0].Cells["id"].Value);
            Admin.DeleteAdminById(selectedAdminId);


            // Refresh the member list after deletion
            LoadAllAdmins();

            MessageBox.Show("Admin deleted successfully!");
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            LoadAllAdmins();

        }
        private void LoadAllAdmins()
        {
            // Fetch all members from the database
            List<Admin> admins = Admin.GetAllAdmins();

            // Bind the members list to the DataGridView or ListView
            dgvAdmin.DataSource = admins;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

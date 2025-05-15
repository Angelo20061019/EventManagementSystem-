using Event_MS.Classes;
using Event_MS.GUIs;
using System.Runtime.InteropServices;

namespace Event_MS
{
    public partial class LoginForm : Form
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
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void linkMemberSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMember loginMember = new LoginMember();
            loginMember.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUName.Text;
            string password = txtUPassword.Text;

            if (radiobtnAmin.Checked)
            {
                Admin admin = Admin.GetAdmin(name, password);
                if (admin != null)
                {
                    MessageBox.Show("Login successful!");
                    AdminDashBoard adminDashBoard = new AdminDashBoard();
                    adminDashBoard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
            else if (radiobtnMember.Checked)
            {
                Participant member = Participant.GetMember(name, password);
                if (member != null)
                {
                    MessageBox.Show("Login successful!");
                    MemberDashBoard adminDashBoard = new MemberDashBoard(member);
                    adminDashBoard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
            else
            {
                MessageBox.Show("Please select a Role");
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtUName.Clear();
            txtUPassword.Clear();
        }

        private void showPW_CheckedChanged(object sender, EventArgs e)
        {
            if (showPW.Checked)
            {
                txtUPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtUPassword.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

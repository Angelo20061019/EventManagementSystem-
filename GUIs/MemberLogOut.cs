using Event_MS.Classes;

namespace Event_MS.GUIs
{
    public partial class MemberLogOut : Form
    {
        private Participant member;
        public MemberLogOut(Participant member)
        {
            this.member = member;
            InitializeComponent();
        }

        private void btnMemberLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberDashBoard memberDashBoard = new MemberDashBoard(member);
            memberDashBoard.Show();
            this.Hide();
        }
    }
}

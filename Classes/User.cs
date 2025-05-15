namespace Event_MS.Classes
{
    public class User
    {
        private string name;
        private string password;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public virtual string GetRole()
        {
            return "User";
        }
    }
}

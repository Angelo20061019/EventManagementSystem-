using MySql.Data.MySqlClient;

namespace Event_MS.Classes
{
    public class Participant : User
    {
        private string id;
        private string email;
        private string tp;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Tp
        {
            get { return tp; }
            set { tp = value; }
        }

        public Participant(string id, string name, string password, string email, string tp)
            : base(name, password)
        {
            this.id = id;
            this.email = email;
            this.tp = tp;
        }
        public override string GetRole()
        {
            return "Member";
        }

        //create data base connection
        private static string connectionString = "server=localhost;database=eventms;user=root;password=;";

        //Add member to database
        public static void AddMember(User user)
        {
            if (user is Participant member)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Check how many admins are currently in the database
                        string countQuery2 = "SELECT COUNT(*) FROM member";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery2, conn))
                        {
                            int memberCount = Convert.ToInt32(countCmd.ExecuteScalar());

                            // Check if the number of admins is less than 50
                            if (memberCount >= 200)
                            {
                                MessageBox.Show("The member limit of 200 has been reached. No more members can be added.");
                                return;
                            }
                        }

                        //Add member to data base 
                        string query = "INSERT INTO member (id, name, password, email, tp) VALUES (@id, @name, @password, @email, @tp)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", member.Id);
                            cmd.Parameters.AddWithValue("@name", member.Name);
                            cmd.Parameters.AddWithValue("@password", member.Password);
                            cmd.Parameters.AddWithValue("@email", member.Email);
                            cmd.Parameters.AddWithValue("@tp", member.Tp);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Member has registered!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding member: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        // Get member details for login
        public static Participant GetMember(string name, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM member WHERE name = @name AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Participant(
                                    reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    reader["password"].ToString(),
                                    reader["email"].ToString(),
                                    reader["tp"].ToString()
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving member: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return null;
        }

        // Display all members in DashBoard tables
        public static List<Participant> GetAllMembers()
        {
            List<Participant> members = new List<Participant>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM member";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                members.Add(new Participant(
                                    reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    reader["password"].ToString(),
                                    reader["email"].ToString(),
                                    reader["tp"].ToString()
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving members: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return members;
        }

        // Method to delete a member from the database
        public static void DeleteMemberById(int memberId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM member WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", memberId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting member: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}

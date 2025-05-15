using MySql.Data.MySqlClient;

namespace Event_MS.Classes
{
    internal class Admin : User
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

        public Admin(string id, string name, string password, string email, string tp)
            : base(name, password)
        {
            this.id = id;
            this.email = email;
            this.tp = tp;
        }

        public override string GetRole()
        {
            return "Admin";
        }

        //create data base connection
        private static string connectionString = "server=localhost;database=eventms;user=root;password=;";

        // Add admin to the database
        public static void AddAdmin(User user)
        {
            if (user is Admin admin)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        // Check how many admins are currently in the database
                        string countQuery = "SELECT COUNT(*) FROM admin";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                        {
                            int adminCount = Convert.ToInt32(countCmd.ExecuteScalar());

                            // Check if the number of admins is less than 50
                            if (adminCount >= 50)
                            {
                                MessageBox.Show("The admin limit of 50 has been reached. No more admins can be added.");
                                return;
                            }
                        }
                        //Add admin to data base 
                        string query = "INSERT INTO admin (id, name, password, email, tp) VALUES (@id, @name, @password, @email, @tp)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", admin.Id);
                            cmd.Parameters.AddWithValue("@name", admin.Name);
                            cmd.Parameters.AddWithValue("@password", admin.Password);
                            cmd.Parameters.AddWithValue("@email", admin.Email);
                            cmd.Parameters.AddWithValue("@tp", admin.Tp);
                            cmd.ExecuteNonQuery();
                        }


                        MessageBox.Show("Admin has registered!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding admin: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        // Get admin details for login
        public static Admin GetAdmin(string name, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM admin WHERE name = @name AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Admin(
                                    reader["name"].ToString(),
                                    reader["id"].ToString(),
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
                    MessageBox.Show("Error retrieving admin: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return null;
        }

        // Display all admins in DashBoard tables
        public static List<Admin> GetAllAdmins()
        {
            List<Admin> admins = new List<Admin>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM admin";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                admins.Add(new Admin(

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
                    MessageBox.Show("Error retrieving admins: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return admins;
        }

        // Method to delete a admin from the database
        public static void DeleteAdminById(int adminId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM admin WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", adminId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting admin: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}

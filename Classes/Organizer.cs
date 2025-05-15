using MySql.Data.MySqlClient;

namespace Event_MS.Classes
{
    internal class Organizer : Events
    {
        private string venue;
        private string ticketprice;
        private string ticketsavailable;

        public string Venue
        {
            get { return venue; }
            set { venue = value; }
        }
        public string TicketPrice
        {
            get { return ticketprice; }
            set { ticketprice = value; }
        }
        public string TicketsAvailable
        {
            get { return ticketsavailable; }
            set { ticketsavailable = value; }
        }
        public Organizer(string eventid, string eventname, string venue, string eventtype, string ticketprice, string ticketsavailable)
            : base(eventid, eventname, eventtype)
        {
            this.venue = venue;
            this.ticketprice = ticketprice;
            this.ticketsavailable = ticketsavailable;
        }

        //create data bse connection
        private static string connectionString = "server=localhost;database=eventms;user=root;password=;";

        // Add events to database
        public static void AddEvent(Organizer events)
        {
            if (events is Organizer manageEvents)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Check how many admins are currently in the database
                        string countQuery3 = "SELECT COUNT(*) FROM manageevents";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery3, conn))
                        {
                            int eventCount = Convert.ToInt32(countCmd.ExecuteScalar());

                            // Check if the number of admins is less than 50
                            if (eventCount >= 20)
                            {
                                MessageBox.Show("The event limit of 20 has been reached. No more events can be added.");
                                return;
                            }
                        }

                        //Add member to data base 
                        string query = "INSERT INTO manageevents (eventname, eventtype, eventvenue, ticketprice, ticketsavailable) VALUES (@eventname, @eventtype, @venue, @ticketprice, @ticketsavailable)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@eventname", manageEvents.EventName);
                            cmd.Parameters.AddWithValue("@eventtype", manageEvents.EventType);
                            cmd.Parameters.AddWithValue("@venue", manageEvents.Venue);
                            cmd.Parameters.AddWithValue("@ticketprice", manageEvents.TicketPrice);
                            cmd.Parameters.AddWithValue("@ticketsavailable", manageEvents.TicketsAvailable);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Event has added!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding event: " + ex.Message + ex.Source);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        // Display all events in table
        public static List<Organizer> GetAllEvents()
        {
            List<Organizer> manageEvents = new List<Organizer>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM manageevents";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                manageEvents.Add(new Organizer(
                                    reader["eventid"].ToString(),
                                    reader["eventname"].ToString(),
                                    reader["eventtype"].ToString(),
                                    reader["eventvenue"].ToString(),
                                    reader["ticketprice"].ToString(),
                                    reader["ticketsavailable"].ToString()
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving events: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return manageEvents;
        }

        // Delete event from database
        public static void DeleteEvent(int eventId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM manageevents WHERE eventid = @eventId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventId", eventId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting event: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}

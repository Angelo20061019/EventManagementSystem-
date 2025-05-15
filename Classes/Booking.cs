using MySql.Data.MySqlClient;

namespace Event_MS.Classes
{
    internal class Booking : Events
    {
        private string bookingid;
        private string memberid;

        public string BookingId
        {
            get { return bookingid; }
            set { bookingid = value; }
        }
        public string MemberId
        {
            get { return memberid; }
            set { memberid = value; }
        }

        public Booking(string bookingid, string eventid, string eventname, string eventtype, string memberid)
            : base(eventid, eventname, eventtype)
        {
            this.bookingid = bookingid;
            this.memberid = memberid;
        }


        //create data base connection
        private static string connectionString = "server=localhost;database=eventms;user=root;password=;";

        // Add booked events to the database
        public void BookEvent()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check the available tickets for the event
                    string checkAvailabilityQuery = "SELECT ticketsavailable FROM manageevents WHERE eventid = @eventid";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkAvailabilityQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@eventid", this.EventId);
                        int ticketsAvailable = Convert.ToInt32(checkCmd.ExecuteScalar());

                        // If no tickets are available, show message and stop the booking
                        if (ticketsAvailable <= 0)
                        {
                            MessageBox.Show("Tickets are sold out for this event.");
                            return;
                        }
                    }

                    // Update tickets available for the event
                    string query1 = "UPDATE manageevents SET ticketsavailable = ticketsavailable - 1 WHERE eventid = @eventid";

                    // Insert booking details into the bookedevents table
                    string query2 = "INSERT INTO bookedevents (eventid, memberid, eventname, eventtype) VALUES (@eventid, @memberid, @eventname, @eventtype)";

                    // Insert booked event details
                    using (MySqlCommand cmd = new MySqlCommand(query2, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventid", this.EventId);
                        cmd.Parameters.AddWithValue("@memberid", this.MemberId);
                        cmd.Parameters.AddWithValue("@eventname", this.EventName);
                        cmd.Parameters.AddWithValue("@eventtype", this.EventType);
                        cmd.ExecuteNonQuery();
                    }

                    // Update the tickets available
                    using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventid", this.EventId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Event Booked successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error booking event: " + ex.Message + ex.Source);
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        // Retrieve all booked events from the database
        public static List<Booking> AllBookedEvents(string memberId)
        {
            List<Booking> bookedEvents = new List<Booking>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM bookedevents WHERE memberid = @memberid";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberid", memberId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                bookedEvents.Add(new Booking(
                                    reader["bookingid"].ToString(),
                                    reader["eventid"].ToString(),
                                    reader["eventname"].ToString(),
                                    reader["eventtype"].ToString(),
                                    reader["memberid"].ToString()
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving booked events: " + ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    conn.Close();
                }
            }

            return bookedEvents;
        }

        // Method to delete a admin from the database
        public static void DeleteEventById(int bookingid)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM bookedevents WHERE bookingid = @bookingid";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookingid", bookingid);
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

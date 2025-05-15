namespace Event_MS.Classes
{
    internal class Events
    {
        //private DataBase db = new DataBase();
        private string eventid;
        private string eventname;
        private string eventtype;

        public string EventId
        {
            get { return eventid; }
            set { eventid = value; }
        }
        public string EventName
        {
            get { return eventname; }
            set { eventname = value; }
        }
        public string EventType
        {
            get { return eventtype; }
            set { eventtype = value; }
        }

        public Events(string eventid, string eventname, string eventtype)
        {
            this.eventid=eventid;
            this.eventname=eventname;
            this.eventtype=eventtype;
        }
    }
}

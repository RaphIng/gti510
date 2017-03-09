namespace CalendArt.Core.Domain
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        //public int TypeId { get; set; } //**avec enum? comment faire avec bonne pratique? - Vincent**
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
        public string Location { get; set; }
        //public ArrayList Membres { get; set; }
    }
}
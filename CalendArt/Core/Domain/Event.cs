using System;
using System.ComponentModel;

namespace CalendArt.Core.Domain
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        //public int TypeId { get; set; } //**avec enum? comment faire avec bonne pratique? - Vincent**
        [DisplayName("Date de début")]
        public DateTime StartDateTime { get; set; }
        [DisplayName("Date de fin")]
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }
        [DisplayName("L'évènement dure tout la journée")]
        public bool IsAllDay { get; set; }
        //public ArrayList Membres { get; set; }
    }
}
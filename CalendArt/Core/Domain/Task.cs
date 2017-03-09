using System;

namespace CalendArt.Core.Domain
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        //public int TypeId { } // devoir, quiz/test, examen, etc.. ** avec enum? comment faire avec bonne pratique? - Vincent **
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
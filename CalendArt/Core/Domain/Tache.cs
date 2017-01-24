using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendArt.Core.Domain
{
    public class Tache
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        //public int TypeId { } // devoir, quiz/test, examen, etc.. ** avec enum? comment faire avec bonne pratique? - Vincent **
        public string Description { get; set; }
        public DateTime DateHeure { get; set; }
        public int Ponderation { get; set; }
    }
}
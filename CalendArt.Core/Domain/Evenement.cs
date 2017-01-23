using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace CalendArt.Core.Domain
{
    public class Evenement
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        //public int TypeId { get; set; } //**avec enum? comment faire avec bonne pratique? - Vincent**
        public DateTime DateHeure { get; set; }
        public string Location { get; set; }
        public ArrayList Membres { get; set; }
    }
}
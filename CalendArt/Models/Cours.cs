using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendArt.Models
{
    public class Cours
    {
        public int Id { get; set; }
        public string Sigle { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Professeur { get; set; }
    }
}
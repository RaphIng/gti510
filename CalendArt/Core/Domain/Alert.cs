using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendArt.Core.Domain
{
    public class Alert
    {
        public int Id { get; set; }
        public string Debut { get; set; }
        public string Fin { get; set; }
        public string Rappel { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace CalendArt.Core.Domain
{
    public class Calendar
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }
    }
}
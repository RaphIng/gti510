using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendArt.Models;
using Google.Apis.Calendar.v3.Data;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CalendArt.GoogleEvents
{
    interface GoogleEventService
    {
        IQueryable<GoogleEvent> FindAll();

        



    }
}

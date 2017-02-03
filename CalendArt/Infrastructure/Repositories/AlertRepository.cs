using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendArt.Core.Domain;
using CalendArt.Core.Repositories;

namespace CalendArt.Infrastructure.Repositories
{
    public class AlertRepository : Repository<Alert>, IAlertRepository
    {
        public AlertRepository(CalendArtContext context)
            : base(context)
        {
        }

        public CalendArtContext CalendArtContext
        {
            get { return Context as CalendArtContext; }
        }
    }
}

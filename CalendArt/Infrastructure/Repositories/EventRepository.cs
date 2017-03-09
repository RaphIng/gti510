using CalendArt.Core.Domain;
using CalendArt.Core.Repositories;

namespace CalendArt.Infrastructure.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(CalendArtContext context)
            : base(context)
        {
        }

        public CalendArtContext CalendArtContext
        {
            get { return Context as CalendArtContext; }
        }
    }
}
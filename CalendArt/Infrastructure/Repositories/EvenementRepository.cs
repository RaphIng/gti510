using CalendArt.Core.Domain;
using CalendArt.Core.Repositories;

namespace CalendArt.Infrastructure.Repositories
{
    public class EvenementRepository : Repository<Evenement>, IEvenementRepository
    {
        public EvenementRepository(CalendArtContext context)
            : base(context)
        {
        }

        public CalendArtContext CalendArtContext
        {
            get { return Context as CalendArtContext; }
        }
    }
}
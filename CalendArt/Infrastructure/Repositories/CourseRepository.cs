using CalendArt.Core.Domain;
using CalendArt.Core.Repositories;

namespace CalendArt.Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(CalendArtContext context)
            : base(context)
        {
        }

        public CalendArtContext CalendArtContext
        {
            get { return Context as CalendArtContext; }
        }
    }
}

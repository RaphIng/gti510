using CalendArt.Core.Domain;

namespace CalendArt.Core.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        // We can add specific methods like
        // IEnumerable<Course> GetCourseWithCode(string code)
    }
}

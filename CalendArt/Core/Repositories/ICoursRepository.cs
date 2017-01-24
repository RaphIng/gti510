using CalendArt.Core.Domain;

namespace CalendArt.Core.Repositories
{
    public interface ICoursRepository : IRepository<Cours>
    {
        // on peut ajouter des méthodes spécifiques aux cours telles que
        // IEnumerable<Cours> GetCoursAvecSigle(string sigle)
    }
}

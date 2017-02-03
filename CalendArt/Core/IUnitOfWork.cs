using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendArt.Core.Repositories;

namespace CalendArt.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICoursRepository Cours { get; }
        IAlertRepository Alert { get; }
        // ajouter les autre interfaces repos
        //.
        //.
        //.

        int Complete();
    }
}

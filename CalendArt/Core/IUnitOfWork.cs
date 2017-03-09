using System;
using CalendArt.Core.Repositories;

namespace CalendArt.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
		IEventRepository Events { get; }
        IReminderRepository Reminders { get; }
        ITaskRepository Tasks { get; }
        // Add the other repositories
        //.
        //.
        //.

        int Complete();
    }
}

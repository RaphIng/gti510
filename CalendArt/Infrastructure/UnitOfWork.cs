using CalendArt.Core;
using CalendArt.Core.Repositories;
using CalendArt.Infrastructure.Repositories;

namespace CalendArt.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CalendArtContext _context;

        public ICourseRepository Courses { get; private set; }
        public IEventRepository Events { get; private set; }
		public IReminderRepository Reminders { get; private set; }
        public ITaskRepository Tasks { get; private set; }

        public UnitOfWork(CalendArtContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
			Events = new EventRepository(_context);
            Reminders = new ReminderRepository(_context);
            Tasks = new TaskRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

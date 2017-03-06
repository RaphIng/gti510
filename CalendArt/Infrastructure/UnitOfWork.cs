using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendArt.Core;
using CalendArt.Core.Repositories;
using CalendArt.Infrastructure.Repositories;

namespace CalendArt.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CalendArtContext _context;

        public ICoursRepository Cours { get; private set; }
        public IEvenementRepository Evenements { get; private set; }
		public IAlertRepository Alert { get; private set; }
        // ajouter autres

        public UnitOfWork(CalendArtContext context)
        {
            _context = context;
            Cours = new CoursRepository(_context);
			Evenements = new EvenementRepository(_context);
            Alert = new AlertRepository(_context);            
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

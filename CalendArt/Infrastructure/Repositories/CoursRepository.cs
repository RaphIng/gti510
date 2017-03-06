﻿using CalendArt.Core.Domain;
using CalendArt.Core.Repositories;

namespace CalendArt.Infrastructure.Repositories
{
    public class CoursRepository : Repository<Cours>, ICoursRepository
    {
        public CoursRepository(CalendArtContext context)
            : base(context)
        {
        }

        public CalendArtContext CalendArtContext
        {
            get { return Context as CalendArtContext; }
        }
    }
}

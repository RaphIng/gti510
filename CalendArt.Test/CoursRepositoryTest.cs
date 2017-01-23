using System;
using System.Linq;
using CalendArt.Infrastructure.Repositories;
using CalendArt.Infrastructure;
using CalendArt.Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalendArt.Test
{
    [TestClass]
    public class CoursRepositoryTest
    {
        private CoursRepository _repository;
        private CalendArtContext _context;

        [TestInitialize]
        public void TestSetUp()
        {
            _context = new CalendArtContext();
            _repository = new CoursRepository(_context);
        }

        [TestMethod]
        public void CanGetAll()
        {
            _context.Cours.Add(
                new Cours
                {
                    Sigle = "GTI525",
                    Titre = "Test"
                }
            );
            _context.SaveChanges();
            /*var result = _repository.GetAll();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(1, numberOfRecords);*/
        }
    }
}

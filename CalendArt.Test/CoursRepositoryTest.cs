using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendArt.Infrastructure.Repositories;
using CalendArt.Infrastructure;
using CalendArt.Core.Domain;
using CalendArt.Core.Repositories;
using System.Linq;
using Moq;
using System.Collections.Generic;
using CalendArt.Controllers;

namespace CalendArt.Test
{
    // Tests d'intégration pour CoursRepository
    [TestClass]
    public class CoursRepositoryTest
    {
        private CoursRepository _coursRepo;
            
        [TestInitialize]
        public void TestSetUp()
        {
            _coursRepo = new CoursRepository(new CalendArtContext());
            //_coursRepo = new Mock<IC>
        }

        [TestMethod]
        /*public void Test_AddOneCours()
        {
            // Arrange
            var coursRepo = new Mock<ICoursRepository>();
            var coursController = new CoursController();
            var cours = new List<Cours>
            {
                new Cours { Sigle = "GTI510", Titre = "Gestion de projet et assurance de la qualité" }
            };
            coursRepo.Setup(x => x.GetAll()).Returns(cours.AsQueryable());
            //cours

            // Act
            var result = coursController.Create();

            // Assert
            Assert.AreEqual(coursRepo.Setup(x => x.GetAll().Count, )
            _coursRepo.Add(new Cours
            {
                Sigle = "GTI510",
                Titre = "Gestion de projet et assurance de la qualité"
            });
            var expectedCount = _coursRepo.GetAll().Count();
            //Assert.AreEqual(expectedCount, actualCount + 1);
            Assert.AreEqual(actualCount, 1);
        }*/
    }
}

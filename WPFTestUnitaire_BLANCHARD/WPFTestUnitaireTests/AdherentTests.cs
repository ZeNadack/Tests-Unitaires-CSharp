using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFTestUnitaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestUnitaire.Tests
{
    [TestClass()]
    public class AdherentTests
    {
        [TestMethod()]
        public void AdherentTest()
        {
            DateTime dt = new DateTime(2000, 12, 25);
            Adherent adh = new Adherent("1234567", "Durand", "Paul", dt);
            //test du fonctionnement du constructeur avec les accesseurs
            Assert.AreEqual("1234567", adh.getId());
            Assert.AreEqual("Durand", adh.getNom());
            Assert.AreEqual("Paul", adh.getPrenom());
            Assert.AreEqual(dt, adh.getDate());
        }

        /*
        [TestMethod()]
        public void getDateNaissanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getNomTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getPrenomTest()
        {
            Assert.Fail();
        }
        */

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testReglesMetier1()
        {
            //Appel du constructeur de Adherent avec un identifiant incorrect
            //A vous de compléter
            DateTime dt = new DateTime(2000, 12, 25);
            Adherent adh = new Adherent("123456", "Doe", "John", dt);
            Assert.Fail("Erreur non détectée : l'identifiant doit comporter 7 caractères");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testReglesMetier2() 
        {
            DateTime dt = new DateTime(2010, 12, 25);
            Adherent adh = new Adherent("1234567", "Doe", "John", dt);
            
            Assert.Fail("Erreur non détectée : l'adherent doit être majeur");
        }
    }
}
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
    public class AssociationTests
    {
        private Association ass;

        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            ass = new Association("Aslv");
            DateTime dt = new DateTime(2000,12,25);
            ass.ajoutAdherent("Aslv001", "Durand", "Paul", dt);
        }


        [TestMethod()]
        public void AssociationTest()
        {
            //test du fonctionnement du constructeur avec l’accesseur getNom
            //Association asso = new Association("VALO");
            string nom = ass.getNom();
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))] //Ne pas oublier !!!!!!!
        public void testReglesMetier1()
        {
            //test de la longueur du nom de l’association
            Association asso = new Association("VAL");
            Assert.Fail("Erreur : l'identifiant doit comporter 4 caractères");
        }

        /*
        [TestMethod()]
        public void getNomTest()
        {
            Assert.Fail();
        }
        */

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void ajoutAdherentTest()
        {
            //Déclaration d'une association et ajout de deux adhérents avec le même identifiant
            // Association asso = new Association("VALO");

            DateTime dt = new DateTime(2000, 12, 25);
            Adherent adh1 = new Adherent("1234567", "Doe", "John", dt);
            Adherent adh2 = new Adherent("1234567", "Depardieu", "Gerard", dt);

            ass.ajoutAdherent(adh1.getId(), adh1.getNom(), adh1.getPrenom(), adh1.getDate());
            ass.ajoutAdherent(adh2.getId(), adh2.getNom(), adh2.getPrenom(), adh2.getDate());

            Assert.Fail("L'identifiant a déjà été utilisé");
        }
    }
}
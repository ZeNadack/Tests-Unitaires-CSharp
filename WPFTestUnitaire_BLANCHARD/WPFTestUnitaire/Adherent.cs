using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestUnitaire
{
    public class Adherent
    {
        private DateTime DateNaissance;
        private string Id, Nom, Prenom;

        public Adherent(string unId, string unNom, string unPrenom, DateTime uneDateNaissance)
        {
            //Test de la longueur de l’identifiant A vous de compléter
            if (unId.Length != 7)
            {
                throw new Exception("L’identifiant " + unId + " doit comporter 7 caractères");
            }
            else if ((DateTime.Now.Year - uneDateNaissance.Year) < 18)
            {
                throw new Exception("L’adherent n'est pas majeur");
            }
            else
            {
                DateNaissance = uneDateNaissance;
                Id = unId;
                Nom = unNom;
                Prenom = unPrenom;
            }
        }

        public DateTime getDate()
        {
            return (DateNaissance);
        }

        public string getId()
        {
            return (Id);
        }

        public string getNom()
        {
            return (Nom);
        }

        public string getPrenom()
        {
            return (Prenom);
        }

    }
}

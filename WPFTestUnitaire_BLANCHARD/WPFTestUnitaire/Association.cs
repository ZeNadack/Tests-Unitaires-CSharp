using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestUnitaire
{
    public class Association
    {
        string Nom;
        Dictionary<string, Adherent> ListeAdherents;

        public Association(string NomA)
        {
            //Initialisation du nom et Allocation mémoire pour le dictionnaire
            Nom = NomA;
            ListeAdherents = new Dictionary<string, Adherent>();
            if (Nom.Length != 4)
            {
                throw new Exception("Le nom de l'association doit comporter 4 caractères");
            }
        }
        public string getNom()
        {
            return Nom;
        }

        public Dictionary<string, Adherent> getListeAdherent()
        {
        return ListeAdherents;
        }

        public void ajoutAdherent(string IdA, string NomAd, string PrenomAd, DateTime
       DateNaissanceAd)
        {
            Adherent adh = new Adherent(IdA, NomAd, PrenomAd, DateNaissanceAd);
            if (ListeAdherents.ContainsKey(IdA)) 
            {
                throw new Exception("L'identifiant a déjà été utilisé");
            }
            else
            {
                ListeAdherents.Add(IdA, adh);
            }
        }
    }
}

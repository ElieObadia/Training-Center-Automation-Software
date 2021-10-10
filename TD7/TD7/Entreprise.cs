using System;
using System.Collections.Generic;
using System.Text;

namespace TD7
{
    class Entreprise: IComparable
    {
        string nom;
        string adresse;
        string siegesocial;

        public Entreprise (string nom, string adresse, string siegesocial)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.siegesocial = siegesocial;
        }

        public string Nom { get { return this.nom; } }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Entreprise otherentreprise = obj as Entreprise;
            if (otherentreprise != null)
            {
                return this.nom.CompareTo(otherentreprise.Nom);
            }
            else
            {
                throw new ArgumentException("Object is not a Entreprise");
            }
        }

        public override string ToString()
        {
            return this.nom + " " + this.adresse + " " + this.siegesocial;
        }
    }
}

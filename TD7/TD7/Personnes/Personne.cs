using System;
using System.Collections.Generic;
using System.Text;

namespace TD7
{
    abstract class Personne
    {
        protected string nom;
        protected string adresse;
        protected int numtelephone;

        public Personne (string nom, string adresse, int numtelephone)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.numtelephone = numtelephone;
        }

        public string Nom { get { return this.nom; } }

        public override string ToString()
        {
            return this.nom + " " + this.adresse + " " + this.numtelephone;
        }
    }
}

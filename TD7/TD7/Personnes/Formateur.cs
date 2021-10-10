using System;
using System.Collections.Generic;
using System.Text;

namespace TD7
{
    class Formateur : Personne
    {
        int numsecu;

        public Formateur(string nom, string adresse, int numtelephone, int numsecu) : base(nom, adresse, numtelephone)
        {
            this.numsecu = numsecu;
        }

        public override string ToString()
        {
            return nom + " " + adresse + " " + numtelephone + " " + this.numsecu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TD7
{
    class CourteDuree : Formation
    {
        List<string> listemat;
        const int prix = 175;

        public CourteDuree(string nom, List<Participant> liste, List<string> listemat = null) : base(nom, liste)
        {
            this.listemat = listemat;
        }

        public List<string> Listemat { get { return this.listemat; } }

        public override string ToString()
        {
            string retour = "";
            foreach (string m in listemat)
            {
                retour = retour + m + "\n";
            }
            return nom + " " + nbparticipant + "\n" + retour;
        }

        public int PrixTotal()
        {
            return listemat.Count * prix;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TD7
{
    class LongueDuree : Formation
    {
        List<Formateur> listeform;
        int nbjour;
        const int prix = 200;

        public LongueDuree(string nom, List<Participant> liste, int nbjour, List<Formateur> listeform = null) : base(nom, liste)
        {
            this.listeform = listeform;
            this.nbjour = nbjour;
        }

        public override string ToString()
        {
            string retour = "";
            foreach(Formateur f in listeform)
            {
                retour = retour + f + "\n";
            }
            return nom + " " + nbparticipant + "\n" + retour;
        }

        public int PrixTotal()
        {
            return prix * nbjour;
        }
    }
}

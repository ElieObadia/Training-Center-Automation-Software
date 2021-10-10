using System;
using System.Collections.Generic;
using System.Text;

namespace TD7
{
    class CentreDeFormation
    {
        string nom;
        List<Formation> listeform;

        public CentreDeFormation(string nom, List<Formation> listeform)
        {
            this.nom = nom;
            this.listeform = listeform;
        }

        public override string ToString()
        {
            string retour = "";
            foreach(Formation f in listeform)
            {
                retour = retour + f + "\n";
            }
            return this.nom+ " " + retour;
        }

        public int PlusDeDix()
        {
            int retour = 0;
            foreach(Formation f in listeform)
            {
                if (f.Nbparticipant >= 10)
                {
                    retour++;
                }
            }
            return retour;
        }
    }
}

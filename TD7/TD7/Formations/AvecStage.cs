using System;
using System.Collections.Generic;
using System.Text;

namespace TD7
{
    class AvecStage : Formation
    {
        List<Entreprise> listeentre;

        public AvecStage(string nom, List<Participant> liste, List<Entreprise> listeentre = null) : base(nom, liste)
        {
            this.listeentre = listeentre;
        }

        public override string ToString()
        {
            string retour = "";
            foreach (Entreprise e in listeentre)
            {
                retour = retour + e + "\n";
            }
            return nom + " " + nbparticipant + "\n" + retour;
        }

        public override void Affichage()
        {
            List<Entreprise> temp = listeentre;
            temp.Sort();
            foreach (Entreprise e in temp)
            {
                Console.WriteLine(e + "\n");
            }
        }
    }
}

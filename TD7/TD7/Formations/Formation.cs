using System;
using System.Collections.Generic;
using System.Text;

namespace TD7
{
    abstract class Formation
    {
        protected string nom;
        protected int nbparticipant;
        protected List<Participant> liste;

        public Formation(string nom, List<Participant> liste=null)
        {
            this.nom = nom;
            this.liste = liste;
            this.nbparticipant = this.liste.Count ;
        }

        public int Nbparticipant { get { return this.nbparticipant; } }

        public override string ToString()
        {
            string retour = "";
            foreach (Participant p in liste)
            {
                retour = retour + p + "\n";
            }
            return this.nom + " " + this.nbparticipant + "\n" + retour;
        }
        
        public virtual void Affichage()
        {
            List<Participant> temp = liste;
            temp.Sort();
            foreach(Participant p in temp)
            {
                Console.WriteLine(p+"\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TD7
{
    class Participant : Personne, IComparable
    {
        int numid;

        public Participant(string nom, string adresse, int numtelephone, int numid):base(nom, adresse, numtelephone)
        {
            this.numid = numid;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Participant otherparticipant = obj as Participant;
            if (otherparticipant != null)
            {
                return nom.CompareTo(otherparticipant.Nom);
            }
            else
            {
                throw new ArgumentException("Object is not a Participant");
            }
        }

        public override string ToString()
        {
            return nom + " " + adresse + " " + numtelephone + " " + this.numid;
        }
    }
}

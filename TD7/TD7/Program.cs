using System;
using System.Collections.Generic;

namespace TD7
{
    class Program
    {
        delegate double Remise(int pourcentage, Formation f);
        static double RemiseParticipant(int pourcentage, Formation f)
        {
            return f.Nbparticipant * pourcentage;
        }
        static double RemiseMatiere(int pourcentage, Formation f)
        {
            double retour = 0;
            if (f is CourteDuree)
            {
                CourteDuree temp = f as CourteDuree;
                retour = pourcentage * temp.Listemat.Count;
            }
            return retour;
        }

        static double AppliquerRemise(Remise o, int pourcentage, Formation f)
        {
            double retour = 0.0;
            if (f is CourteDuree)
            {
                CourteDuree temp = f as CourteDuree;
                double p = o(pourcentage, f) / 100;
                retour = temp.PrixTotal() * (1 - p);
            }
            if (f is LongueDuree)
            {
                LongueDuree temp = f as LongueDuree;
                double p = o(pourcentage, f) / 100;
                retour = temp.PrixTotal() * (1 - p);
            }
            return retour;
        }

        static void Main(string[] args)
        {
            Participant p1 = new Participant("J", "Pa", 075477, 97686);
            Participant p2 = new Participant("A", "Ze", 07646377, 945386);
            Participant p3 = new Participant("F", "PO", 0346377, 9765435);
            Participant p4 = new Participant("G", "Pe", 07535457, 9734586);
            Participant p5 = new Participant("T", "Su", 07543477, 97676586);
            Participant p6 = new Participant("H", "Tu", 075454377, 97354686);
            Participant p7 = new Participant("U", "Pol", 075677477, 97567686);
            Participant p8 = new Participant("P", "Paz", 0755756477, 93567686);
            Participant p9 = new Participant("Q", "Pul", 07547677, 9735686);
            Participant p10 = new Participant("E", "Var", 076545477, 97646686);

            List<Participant> P1 = new List<Participant>() { p1, p2, p3, p4 };
            List<Participant> P2 = new List<Participant>() { p1, p2, p3, p4, p5, p6, p7, p7, p8, p9, p10};
            List<Participant> P3 = new List<Participant>() { p1, p3, p9, p7, p4 };

            Formateur f1 = new Formateur("A", "Lo", 09876, 09876);
            Formateur f2 = new Formateur("B", "Lre", 34876, 09854);
            Formateur f3 = new Formateur("C", "Gre", 06876, 098709);

            List<Formateur> F1 = new List<Formateur>() { f1, f2, f3 };
            List<Formateur> F2 = new List<Formateur>() { f1, f2};

            Entreprise e1 = new Entreprise("F", "hdjd", "hfouhzefn");
            Entreprise e2 = new Entreprise("A", "hefzfd", "mkofzefn");
            Entreprise e3 = new Entreprise("B", "hdjd", "hpkjhfefn");

            List<Entreprise> E1 = new List<Entreprise>() { e1, e2, e3 };
            List<Entreprise> E2 = new List<Entreprise>() { e1, e2 };

            CourteDuree c1 = new CourteDuree("ihoifhz", P1, new List<string>() { "fjnjfv", "jcohefv", "lknjvbfe", "pohfoevho" });
            CourteDuree c2 = new CourteDuree("ihofzfzffhz", P2, new List<string>() { "fjfv", "jfv", "vbfe" });

            LongueDuree lon1 = new LongueDuree("kjbgkj", P3, 12, F2);
            LongueDuree lon2 = new LongueDuree("kjbvfdvdkj", P2, 36, F1);

            AvecStage s1 = new AvecStage("khhjkuh", P2, E2);
            AvecStage s2 = new AvecStage("kjhj", P1, E1);

            List<Formation> listeform = new List<Formation>() { c1, c2, lon1, lon2, s1, s2 };

            CentreDeFormation centre = new CentreDeFormation("Centre", listeform);

            Console.WriteLine("Prix c1 = " + c1.PrixTotal());
            Console.WriteLine("Prix c2 = " + c2.PrixTotal());

            Console.WriteLine("Prix lon1 = " + lon1.PrixTotal());
            Console.WriteLine("Prix lon2 = " + lon2.PrixTotal());

            Console.WriteLine("Plus de 10 = " + centre.PlusDeDix());

            Console.WriteLine("Affichage Entreprise s1 classée");
            s1.Affichage();
            Console.WriteLine("Affichage Entreprise s2 classée");
            s2.Affichage();

            Console.WriteLine("Affichage Participant s1 classé");
            s1.Affichage();
            Console.WriteLine("Affichage Participant s2 classé");
            s2.Affichage();
            Console.WriteLine("Affichage Participant c1 classé");
            c1.Affichage();
            Console.WriteLine("Affichage Participant c2 classé");
            c2.Affichage();
            Console.WriteLine("Affichage Participant lon1 classé");
            lon1.Affichage();
            Console.WriteLine("Affichage Participant lon2 classé");
            lon2.Affichage();

            Console.WriteLine("Prix avant remise pour lon1 : " + lon1.PrixTotal());
            Console.WriteLine("Prix après remise pour lon1 : " + AppliquerRemise(RemiseParticipant, 2, lon1));
            Console.WriteLine("Prix avant remise pour c1 : " + c1.PrixTotal());
            Console.WriteLine("Prix après remise pour c1 : " + AppliquerRemise(RemiseMatiere, 2, c1));

            Console.WriteLine(c1);
        }
    }
}

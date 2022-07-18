using System;
using System.Collections;
using System.Collections.Generic;

namespace _07___code {
    class MonComparateur : IComparer {
        public int Compare(object x, object y) {
            int hx = x.GetHashCode();
            int hy = y.GetHashCode();
            return hx - hy;
        }

        public int CompareDG(int x, int y) {
            return x - y;
        }
    }

    class Personne {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public int Age { get; set; }
        public override string ToString() {
            return String.Format("{0} {1} ({2} ans)", this.Nom, this.Prenom, this.Age);
        }
    }

    class ComparateurPersonnesNom : IComparer<Personne> {
        public int Compare(Personne x, Personne y) {
            return x.Nom.CompareTo(y.Nom);
        }
    }

    class ComparateurPersonnesPrenom : IComparer<Personne> {
        public int Compare(Personne x, Personne y) {
            return x.Prenom.CompareTo(y.Prenom);
        }
    }
    class Program {

        static void TestString() {
            String s = "toto";
            String t = s.Replace('o', 'a');
            Console.WriteLine(s);
            Console.WriteLine(t);
        }

        static void TestArrayList() {
            ArrayList al = new ArrayList();
            al.Add(45);
            al.Add(new Program());
            al.Add(true);
            al.Sort(new MonComparateur());


            foreach (object elt in al) {
                Console.Write("{0}, ", elt);
            }
            Console.WriteLine();
        }

        static void TestListEntiers() {
            List<int> l = new List<int>();
            //  l.Add(new Program());   //  impossible
            l.Add(12);
            l.Add(90);
            l.Add(3);
            l.Add(12);
            l.Sort();
            l.Sort(new MonComparateur().CompareDG);
            l.Sort(new Comparison<int>(new MonComparateur().CompareDG));
            foreach (object elt in l) {
                Console.Write("{0}, ", elt);
            }
            Console.WriteLine();
        }

        static void AfficherListePersonnes(List<Personne> liste) {
            foreach (Personne p in liste) {
                Console.WriteLine(p);
            }
        }
        static void Main(string[] args) {

            List<Personne> l = new List<Personne>();
            l.Add(new Personne { Nom = "St Onge", Prenom = "Leonie", Age = 23 });
            l.Add(new Personne { Nom = "Thera", Prenom = "Jean", Age = 22 });
            l.Add(new Personne { Nom = "Arsene", Prenom = "Arsene", Age = 27 });
            l.Add(new Personne { Nom = "Gros", Prenom = "Charles", Age = 18 });

            Console.WriteLine("------------------AVANT TRI----------------");
            AfficherListePersonnes(l);

            l.Sort(new ComparateurPersonnesNom());
            Console.WriteLine("--------------APRES TRI PAR NOM--------------------");
            AfficherListePersonnes(l);

            l.Sort(new ComparateurPersonnesPrenom());
            Console.WriteLine("--------------APRES TRI PAR PRENOM--------------------");
            AfficherListePersonnes(l);

            l.Sort(new Comparison<Personne>(new ComparateurPersonnesNom().Compare));
            Console.WriteLine("--------------APRES TRI PAR NOM (DELEGUE)--------------------");
            AfficherListePersonnes(l);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___code {
    class Personne {
        public virtual void SayHi() {
            Console.WriteLine("Personne dit bonjour");
        }
    }
    class Etudiant : Personne {
        override public void SayHi() {
            Console.WriteLine("Etudiant dit bonjour");
        }

        public override string ToString() {
            return "Je suis un etudiant";
        }
    }

    class Program {

        private String nom;
        public string Nom {
            get { return nom; }
            set { this.nom = value; }
        }

        public string Nom2 {
            get; set;
        }

        Etudiant etu;

        public static void Main(string[] args) {
            Etudiant stu = new Etudiant();
            stu.SayHi();

            Console.WriteLine(stu);
        }
    }

}

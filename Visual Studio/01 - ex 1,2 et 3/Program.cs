using System;

namespace _01___ex_1_2_et_3 {

    namespace question1 {
        class Question1 {
            public static void Q1() {
                Console.Write("Rayon du cercle ? ");
                double r = double.Parse(Console.ReadLine());
                double p = 2 * Math.PI * r;
                double s = Math.PI * r * r;
                Console.WriteLine("Perimetre: {0}", p);
                Console.WriteLine("Surface: {0}", s);
            }
        }
    }

    namespace question2 {
        class Question2 {
            public static String DemanderInfo(String question) {
                Console.Write(question);
                return Console.ReadLine();
            }

            public static void Q2() {
                String nom_cie = Question2.DemanderInfo("Nom de la compagnie ? ");
                String adresse_cie = Question2.DemanderInfo("Adresse de la compagnie ? ");
                long tel_cie = Convert.ToInt64(Question2.DemanderInfo("Telephone de la compagnie ? "));
                //...
                Console.WriteLine("Nom compagnie : {0}", nom_cie);
                Console.WriteLine("Adresse de la compagnie : {0}", adresse_cie);
                Console.WriteLine("Telephone de la compagnie : {0}", tel_cie);
            }
        }
    }

    namespace question3 {
        class Question3 {
            public static void Q3() {
                Console.Write("Entrer un nombre : ");
                int n = int.Parse(Console.ReadLine());

                int somme = 0;
                for (int i = 0; i < n; i++) {
                    Console.Write("  Sasir le #{0} nombre : ", i+1);
                    int v = int.Parse(Console.ReadLine());
                    somme += v;
                }

                Console.WriteLine("La somme de ces nombres vaut {0}", somme);
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            //question1.Question1.Q1();
            //question2.Question2.Q2();
            question3.Question3.Q3();

            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04__correction {
    class Question1 {
        //static int GetMax(int a, int b) {
        //    return Math.Max(a, b);
        //}

        static int GetMax(params int[] values) {
            int maxCourant = values[0];
            foreach (int value in values) {
                if (value > maxCourant) {
                    maxCourant = value;
                }
                maxCourant = Math.Max(maxCourant, value);
            }
            return maxCourant;
        }

        public static void Test() {
            int n1 = 124, n2 = 345;
            Console.WriteLine("le plus grand de {0} et {1} vaut {2}", n1, n2, GetMax(n1, n2));

            Console.WriteLine(GetMax(1, 2, 3, 4));

        }
    }
    class Question2 { }
    class Question3 { }
    class Question4 { }
    class Question5 {
        static int LePlusGrand(int[] tab) {
            int indicePlusGrand = 0;

            for (int i = 0; i < tab.Length; i++) {
                if (tab[i] > tab[indicePlusGrand]) {
                    indicePlusGrand = i;
                }
            }

            return indicePlusGrand;
        }

        static int LePlusGrand(int[] tab, int nbElts) {
            int indicePlusGrand = 0;

            for (int i = 0; i < nbElts; i++) {
                if (tab[i] > tab[indicePlusGrand]) {
                    indicePlusGrand = i;
                }
            }

            return indicePlusGrand;
        }

        static void Trier(int[] tab) {
            for(int i = tab.Length - 1; i>0; i--) {
                int indiceMax = LePlusGrand(tab, i + 1);
                //   echanger les elements aux indices indiceMax et i+1
                //  a faire
            }
        }

        public static void Test() {
            int[] tab = { 45, 5, 49, 46, 325, 12, 90
            };
            int indice = Question5.LePlusGrand(tab);
            Console.WriteLine("premiere version : {0}", indice);
            indice = Question5.LePlusGrand(tab, 4);
            Console.WriteLine("seconde version : {0}", indice);
        }
    }
    class Question6 {
        static void MinMaxArray(float[] tab,
            out float? min, out float? max) {

            min = float.MaxValue;
            max = float.MinValue;
            
            if (tab == null || tab.Length == 0) {
                min = null;
                max = null;
                return;
            }


            foreach (float v in tab) {
                if (v < min) {
                    min = v;
                }
                if (v > max) {
                    max = v;
                }
            }
        }
        protected internal static void Test() {
            float? min, max;

            //float[] tab = null;
            float[] tab = new float[0];
            Question6.MinMaxArray(tab, out min, out max);

        }
    }
    class Question7 { }
    class Question8 { }


    class Program {
        static void Main(string[] args) {
            //Question1.Test();
            //Question5.Test();
            Question6.Test();

            Console.WriteLine("Fini");
            Console.ReadLine();
        }
    }
}

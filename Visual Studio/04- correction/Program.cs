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
    class Question5 { }
    class Question6 { }
    class Question7 { }
    class Question8 { }


    class Program {
        static void Main(string[] args) {
            Question1.Test();

            Console.WriteLine("Fini");
            Console.ReadLine();
        }
    }
}

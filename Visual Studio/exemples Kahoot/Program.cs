using System;

namespace exemples_Kahoot {
    class Program {
        void F() {
            Console.WriteLine("Hello World!");
        }

        static void TestOperateur() {
            Program p = new Program();
            p = null;
            p?.F();
        }

        static void TestForEach() {
            int[] tab = { 1, 2, 3, 4, 5 };

            foreach (int e in tab) {
                Console.Write("{0} ", e);
            }
            Console.WriteLine();
        }

        static void TestConversions() {
            float y;
            double x = 3.14159F;
            float z = (float)3.14159;

            long i = 89u;
            //  short j = 89000;    //  impossible

            //int n = (float)32.6;
            var t = 10__000_000_000;
        }

        static void TestTableaux(int[] t) {
            Console.WriteLine("dans TestTableaux: t[0] = {0}", t[0]);
            t[0] = 999;
            Console.WriteLine("dans TestTableaux: t[0] = {0}", t[0]);
        }

        static void Main(string[] args) {
            //Program.TestForEach();


            int[] tab = { 1, 2, 3 };
            Console.WriteLine("dans Main: t[0] = {0}", tab[0]);
            Program.TestTableaux(tab);
            Console.WriteLine("dans Main: t[0] = {0}", tab[0]);


        }
    }
}

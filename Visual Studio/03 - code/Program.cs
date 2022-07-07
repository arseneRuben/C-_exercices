using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___code {
    enum Direction {
        Gauche, Droite, Haut, Bas
    }


    class Program {
        static int count = 0;
        int n;

        static String Hello() {
            String s = "Hello";
            return s;
        }

        static void F() {
            double tmp = 0;
            Program.count++;
            Program.F();
        }
        static void Main(string[] args) {
            //DateTime? dt1 = null;
            //Nullable<DateTime> dt2 = null;
            //Nullable<Program> dir = null;

            //int n =900;
            //Console.WriteLine(n);

            //Program p = new Program();
            //p.n = 135;

            //Program.F();

            int n = 123;
            String h = Program.Hello();
            String h1 = "Hel";
            String aux = h1 + "lo";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___code {
    class Program {
        static void G(ref int n) {
        }
        static void F(int a, int b) {
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
        static void Main(string[] args) {
            Program.F(5, 6);
            Program.F(b: 5, a: 6);

            int p = 13;
            Program.G(ref p);

            Console.WriteLine("fini");
            Console.ReadLine();
        }
    }
}

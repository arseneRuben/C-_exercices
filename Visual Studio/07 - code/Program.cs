using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___code {
    class Program {
        static void Main(string[] args) {
            String s = "toto";
            String r = "ti";
            r = r.Replace("i", "o");
            String t = r + r;

            Console.WriteLine(s == t);
        }
    }
}

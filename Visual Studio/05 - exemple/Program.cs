using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___exemple {
    class Program {
        DateTime DoB {
            get;
        }

        Program() {
            this.DoB = DateTime.Now;
        }

        static void Main(string[] args) {
            Program p = new Program();
            //p.DoB = DateTime.Now;
            Console.WriteLine( p.DoB);
        }
    }
}

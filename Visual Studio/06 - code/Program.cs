using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___code {
    abstract class Object {
        public abstract void F();
    }
    class Program : Object {
        public override void F() {

        }

        static void G() {

        }
        static void Main(string[] args) {

            Object p = new Program();
            p.F();
            Program.G();


        }
    }
}

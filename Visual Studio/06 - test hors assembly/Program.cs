using _06___Classe_abstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___test_hors_assembly {
    class Program : Teacher{
        static void Main(string[] args) {
            Teacher t = new Teacher();
            //  t.address = ""; //  non!

            new Program().address = "";
        }
    }
}

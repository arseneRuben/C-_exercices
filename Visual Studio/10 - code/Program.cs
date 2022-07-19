using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___code {
    class Program {
        void F() {
            throw new NullReferenceException();
        }

        static void Main(string[] args){
            Double d = 0;
            Double x = Math.Sqrt(-64);
            Double y = Double.NaN;
            Console.WriteLine(x);

            SqlConnection conn = new SqlConnection("");
            conn.Open();

            new Program().F();

            throw new IndexOutOfRangeException();
        }
    }
}

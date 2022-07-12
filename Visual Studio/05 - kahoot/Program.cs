using System;

namespace _05___kahoot {

    using file1;

    namespace file1 {
        partial class Test {
            internal int member1;
        }

    //}
    //namespace file2 {
        partial class Test {
            internal int member2;
        }

    }


    class Program {
        static void F(in int n) {
            
        }
        static void Main(string[] args) {
            int a = 13;
            Program.F(in a);
        }
    }
}

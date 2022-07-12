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
        static void Main(string[] args) {
            Test t = new Test();
            
        }
    }
}

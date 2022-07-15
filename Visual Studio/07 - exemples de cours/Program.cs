using System;

namespace _07___exemples_de_cours {
    delegate void DGTest();

    class Autre {
        static void Test() {
            Program.liste = null;
            Program.liste += Program.Jean;
            Program.liste -= Program.Jean;
            Program.liste();

            Program.Evt = null;
            Program.Evt += Program.Jean;
            Program.Evt -= Program.Jean;
            Program.Evt();
        }
    }

    class Program {

        public static DGTest liste;        //  donnee membre d'instance
        public static event DGTest Evt;  //  membre de type evenement


        public static void Jean() {
            Console.WriteLine("Salut Jean !");
        }

        void Leonie() {
            Console.WriteLine("Salut Leonie !");
        }

        static void TestDelegues() {
            Program.liste = new DGTest(Program.Jean); // ou Program.Jean
            Program.liste += new DGTest(Program.Jean);
            Program p = new Program();
            Program.liste += new DGTest(p.Leonie);
            Program.liste -= Program.Jean;
            Program.liste -= p.Leonie;
            Program.liste.Invoke();

            //  ou Program.liste();
        }

        static void TestEvent() {
            Program.Evt += Program.Jean;
            Program.Evt += new Program().Leonie;
            Program.Evt -= Program.Jean;


            if (Program.Evt != null) {
                Program.Evt.Invoke();
                // ou Program.Evt();
            }

            //  OU Program.Evt?.Invoke();
        }
        static void Main(string[] args) {
            //Program.TestDelegues();
            Program.TestEvent();
        }
    }
}

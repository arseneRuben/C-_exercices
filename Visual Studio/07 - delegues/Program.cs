using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___delegues {
    //  1.
    delegate void DGSaySomething(String text);

    //  2.
    class Person {
        public String Name { get; set; }
        internal virtual void SaySomething(String text) {
            Console.WriteLine("Person {0} says: {1}", this.Name, text);
        }
    }

    //  3.
    class Chinese : Person {
        //  4.
        internal new void SaySomething(String text) {
            Console.WriteLine("Chinese {0} says: {1}", this.Name, text);
        }
    }
    class Program {
        static void Main(string[] args) {
            //  5.
            Chinese c = new Chinese() { Name = "Alpha" };
            DGSaySomething myDG = new DGSaySomething(c.SaySomething);
            //  OU DGSaySomething myDG = new Chinese().SaySomething;

            Person p = new Chinese() { Name = "Beta" };
            myDG += p.SaySomething;
            p.Name = "Arsene";
            myDG += p.SaySomething;

            myDG("Nihao!");
            //  OU myDG.Invoke("Nihao!");

            //p.SaySomething("Nihao!");

            Console.WriteLine(myDG.GetInvocationList().Length);

            Console.WriteLine("suppression");
            myDG -= p.SaySomething;
            myDG -= p.SaySomething;
            Console.WriteLine(myDG.GetInvocationList().Length);
            myDG -= c.SaySomething;
            Console.WriteLine(myDG.GetInvocationList().Length);
            myDG("Nihao!");

        }
    }
}

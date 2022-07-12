using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___exercices {
    class Dog {
        internal String name;
    }
    class Student {
        internal String name;
        internal int age;
        internal Dog myDog;
    }
    class Program {
        static void Main(string[] args) {
            Student s = new Student();
            s.name = "toto";
            s.age = 12;
            s.myDog = new Dog();
            s.myDog.name = "Milou";
        }
    }
}

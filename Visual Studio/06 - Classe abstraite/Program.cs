using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Classe_abstraite {
    public abstract class Employee {
        internal String name;
        protected String address;

        public double AnnualSalary { get; set; }

        internal abstract double GetMonthlySalary();
        public override string ToString() {
            return String.Format("{0}, {1} ({2}$/year => {3}$/month)",
                this.name, this.address, this.AnnualSalary,
                this.GetMonthlySalary());
        }
    }

    public class Teacher : Employee {
        internal override double GetMonthlySalary() {
            return this.AnnualSalary / 12;
        }

        public override string ToString() {
            return base.ToString();
        }
    }

    class Boss : Employee {
        internal override double GetMonthlySalary() {
            return this.AnnualSalary / 12;
        }
    }

    class EmployeeTest {
        public static void Test() {
            Teacher prof = new Teacher() {
                name = "Robert",
                address = "25, Cremazie Est",
                AnnualSalary = 120000
            };

            new Teacher().address = "";

            Boss theBoss = new Boss {
                name = "Paul",
                address = "123456789, St Laurent",
                AnnualSalary = 230000
            };

            Console.WriteLine(prof);
            Console.WriteLine(theBoss);
        }
    }

    class Program {
        static void Main(string[] args) {
            EmployeeTest.Test();

            // Employee emp = new Object();     //   NON!
            Object emp1 = new Teacher(); //  upcast implicite
            Object emp2 = (Object)new Teacher(); //  upcast explicite

            //emp1 = new object();
            //Teacher t = (Teacher)emp1;

            Console.WriteLine(emp1 is Object);
            Console.WriteLine(emp1 is Teacher);
        }
    }
}

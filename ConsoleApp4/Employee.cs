using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    internal class Employee
    {
        private string name;
        private int age;
        private int id;
        private int salary;
        private double hra;
        private double da;
        private double Pf;
        private double PT;
        private double total;
        private double nps;

        public Employee()
        {
            name = "Jack";
            age = 22;
            id = 40;
            salary = 2000;
        }
        public Employee(string name, int age, int id,int salary)
        {
            this.name = name;
           this. age =age;
            this.id = id;
            this.salary = salary;

            /*In the existing Emp class accept empid, empname from basic salary from the constructor

            Calculate salary as below

            HRA 40 % of basic
            Da  20 % of basic
            Pf  12 % of basic
            PT =200

            Calculate the total & net paid salary
            Basic +hra+da → total
            Total - (pf+pt)  → net paid salary
            */
  }  
        public void salCal()
        {
             hra = salary * 0.40;
             da = salary * 0.20;
             Pf = salary * 0.12;
             PT = 200;
             total =salary + hra + da;
             nps = total - (Pf+ PT);

        }
    public string Display()
        {
            return $"Employee name is {name} age is {age} and id is {id} Total is {total} and net paid salary is {nps} ";
        }

    }
}

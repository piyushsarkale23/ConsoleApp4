using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.salCal();
            Console.WriteLine(emp.Display());

            Employee emp2 = new Employee("Michael",98,22,100);
            emp2.salCal();
            Console.WriteLine(emp2.Display());

            Book book = new Book();
            Console.WriteLine(book.Display());

            Book book2 = new Book("Success is life", "AJ ", 99);
            Console.WriteLine(book2.Display());

            Studentcs student = new Studentcs(22, "saul", 77, 67, 66);
            student.Calculation();
            Console.WriteLine(student.Display());

            Studentcs student1 = new Studentcs();
            student1.Calculation();
            Console.WriteLine(student1.Display());
        }
    }
}

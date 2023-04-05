using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Studentcs
    {
        // variables or data members
        private int rollno;
        private string name;
        private int eng, hin, maths, total;
        private double percentage;

        //constructor
        public Studentcs()
        {
            rollno = 1;
            name = "Test";
            eng = 0;
            hin = 0;
            maths = 0;

        }
        public Studentcs(int rollno, string name, int eng, int hin, int maths)
        {
            this.rollno = rollno; // this keyword points to the data member
            this.name = name;
            this.eng = eng;
            this.hin = hin;
            this.maths = maths;
        }
        public void Calculation()
        {
            total = eng + hin + maths;
            percentage = (double)total / 3;
        }
        public string Display()
        {
            return $"Roll No {rollno} name {name} total ={total} percentage= {percentage}";

        }
    }
}

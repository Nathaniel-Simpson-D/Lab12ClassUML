using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12ClassUml
{
    public class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student(string name, string address,string program, int year, double fee)
            : base (name,address,"Student")
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;

        }

        public Student()
        {
        }

       

        public override string ToString()
        {
            return $"{Type}: {Name} {Address} {Program} {Year} {Fee}";
        }
    }
}

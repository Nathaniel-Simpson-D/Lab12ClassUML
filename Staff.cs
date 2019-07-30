using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12ClassUml
{
    public class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }
        public Staff(string name, string address,string school, double pay)
            : base (name, address,"Staff")
        {
            this.School = school;
            this.Pay = pay;
        }

        public Staff()
        {
        }

        

        public override string ToString()
        {
            return $"{Type}: {Name} {Address} {School} {Pay}";
        }
    }
}

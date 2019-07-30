using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12ClassUml
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public Person(string _name, string _address, string _type = null)
        {
            this.Name = _name;
            this.Address = _address;
            this.Type = _type;
        }
        public Person()
        {

        }

        public override string ToString()
        {
            return $"{Name} {Address}";
        }
        
    }
}

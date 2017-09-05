using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinMVVM.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<string> Information { get; set; }

        public Person()
        {
        }

        public Person(string name, string surname, IEnumerable<string> information)
        {
            Name = name;
            Surname = surname;
            Information = information;
        }
    }
}

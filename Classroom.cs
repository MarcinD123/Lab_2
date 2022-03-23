using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Classroom
    {
        public string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Classroom(string name, Person[] persons)
        { 


        }

        List<Person>persons = new List<Person>();

    }
}

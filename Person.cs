using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public  class Person
    {
        public string _name;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //constructor
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }


    }
}
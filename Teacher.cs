using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Teacher : Person
    {
        //public string name;
        //public int age;
        public Teacher(string Name,int Age) : base (Name,Age)
        {
            
        }
        public override string ToString()
        {
            return (Name + Age);
        }

    }
}

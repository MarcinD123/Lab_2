using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

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
        List<Person> personslist = new List<Person>();
        
        public Classroom(string name, Person[] persons)
            
        {
            _name = name;
            personslist.AddRange(persons);
            

        }
        
        public override string ToString()
        {
            Console.WriteLine($"Classroom: { _name}");
            Console.WriteLine();
            foreach (var item in personslist)
            {
                Console.WriteLine(item);
                //Console.WriteLine("xD");
            }
            return "";
        }
        

    }
}

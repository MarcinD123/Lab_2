using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using static Lab_2.Task;

namespace Lab_2
{
    public class Student :Person
    { 
        
        public string _group;
        public List<Task> tasks = new List<Task>();
        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public List<Task> tasklist = new List<Task>();
        public Student(string Name, int Age, string group) : base(Name, Age)
        {
            _group = group;
        }
        
        public void AddTask(string name,TaskStatus status)
        {
            
            tasklist.Add(new Task(name, status));
            //Console.WriteLine($"{i}. {name}, [{status}]");
            
        }
        public void UpdateTask(int x,TaskStatus inp)
        {
            //Console.WriteLine(tasklist[x].Status);
            tasklist[x].Status = inp;
        }
        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} ({Age} y.o.)");
            Console.WriteLine($"Group: {Group}");
            int i= 1;
            foreach (var item in tasklist)

            {

                Console.WriteLine($"{i}.{item.Name} [{item.Status}]");
               
                i++;
            }
            return "";
        }
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Student p = (Student)obj;
                return (Name == p.Name) && (Group == p.Group);
            }
        }



    }
}

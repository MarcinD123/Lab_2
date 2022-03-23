using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Student :Person
    { 
        
        public string _group;
        public List<Task> tasks = new List<Task>();
        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        public Student(string Name, int Age, string group) : base(Name, Age)
        {
            _group = group;
        }
        public void AddTask(string name,TaskStatus status)
        {
            Task task = new Task(name, status);
        }
    }
}

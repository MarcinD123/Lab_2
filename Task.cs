using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Lab_2
{
    public class Task
    {

        public string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public TaskStatus _status;
        public TaskStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }



        public enum TaskStatus
        {
            Waiting = 0,
            Progress = 1,
            Done = 2,
            Rejected = 3


        }

        public Task(string name, TaskStatus status)
        {
            _name = name;
            _status = status;
        }
        

    }
}

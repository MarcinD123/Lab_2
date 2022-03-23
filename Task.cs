﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Task
    {

        public string _name;

        public TaskStatus _status;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public enum Taskstatus
        {
            Waiting = 0,
            Progress=1,
            Done = 2,
            Reejcted =3


        }
        
        public Task(string name, TaskStatus status)
        {
            _name = name;
            _status = status;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSTodoApp
{
    public class Task
    { 
        public string Name;
        public int Priority;
        public bool Complete;
        public Task(string name, int priority)
        {
            Name = name;
            Priority = priority;
            Complete = false;
        }
        
    }
}

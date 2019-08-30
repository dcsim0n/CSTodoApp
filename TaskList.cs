using System;
using System.Collections.Generic;
using System.Text;

namespace CSTodoApp
{
    class TaskList
    {
        public List<Task> tasks = new List<Task>();

        public Task NewTask()
        {
            Console.WriteLine("Enter new task name:");
            string name= Console.ReadLine();

            Console.WriteLine("Enter priority for new task:");
            int priority = int.Parse(Console.ReadLine());

            tasks.Add(new Task(name,priority));

            return tasks[tasks.Count - 1];  // return last task
        }

        public void CompleteTask()
        {
            Console.WriteLine("Enter the number of the task you completed:");
            int taskID = int.Parse(Console.ReadLine());

            try
            {
                tasks[taskID].Complete = true;
            }
            catch
            {
                Console.WriteLine("Problem Completing your task, try again");
            }
        }
        public void printTaskList()
        {
            Console.WriteLine("Current Tasks:");
            Console.WriteLine("-------------------------------------------");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"Task {i}:");
                Console.WriteLine($"Name: {tasks[i].Name}");
                Console.WriteLine($"Priority: {tasks[i].Priority}");
                Console.WriteLine($"Complete?: {tasks[i].Complete}");
                Console.WriteLine("-------------------------------------------");

            }
        }
    }
}

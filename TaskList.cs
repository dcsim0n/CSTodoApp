using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CSTodoApp
{
    class TaskContext : DbContext{
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tasks.db");
        }
    }
    class TaskList 
    {
        // public List<Task> tasks = new List<Task>(); 
        public TaskContext db = new TaskContext();

        public void NewTask()
        {
            Console.WriteLine("Enter new task name:");
            string name= Console.ReadLine();

            Console.WriteLine("Enter priority for new task:");
            int priority = int.Parse(Console.ReadLine());

            db.Tasks.Add(new Task {Name = name, Priority = priority} );

            
        }

        public void CompleteTask()
        {
            Console.WriteLine("Enter the number of the task you completed:");
            int taskID = int.Parse(Console.ReadLine());

            try
            {
                Task task = db.Tasks.Find(taskID);
                task.Complete = true;
                db.Tasks.Update(task);
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

            foreach (var task in db.Tasks)
            {
                Console.WriteLine($"Task {task.ID}:");
                Console.WriteLine($"Name: {task.Name}");
                Console.WriteLine($"Priority: {task.Priority}");
                Console.WriteLine($"Complete?: {task.Complete}");
                Console.WriteLine("-------------------------------------------");
                
            }
        }
    }
}

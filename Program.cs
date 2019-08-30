using System;

namespace CSTodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            TaskList tasklist = new TaskList();

            while(choice != 0)
            {
                Console.WriteLine("0: Quit\n1: Add new task\n2: Complete a Task\nShow All Tasks\nWhich do you want?:");
                choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    tasklist.NewTask();
                }

                if(choice == 2)
                {
                    tasklist.printTaskList();
                    tasklist.CompleteTask();
                }

                switch (choice)
                {
                    case 1:
                        tasklist.NewTask();
                        break;

                    case 2:
                        tasklist.printTaskList();
                        tasklist.CompleteTask();
                        break;
                    case 3:
                        tasklist.printTaskList();
                        break;
                    default:
                        break;
                }

            }
        }
    }
}

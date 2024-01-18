using System.Collections.Generic;

namespace ToDoList
{
    internal class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Press: 1 to Add Task");
                Console.WriteLine("Press: 2 to Mark Task");
                Console.WriteLine("Press: 3 to Remove Task");
                Console.WriteLine("Press: 4 to Display Task");
                Console.WriteLine("Press: 5 Exit");

                Console.WriteLine("Enter yout choice: ") ;
                int choice;

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddTask();
                            break;
                        case 2:
                            MarkComplete();
                            break;
                        case 3:
                            RemoveTask();
                            break;
                        case 4:
                            DisplayTask();
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid...");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid...");
                }
            }
        }
        
        static void AddTask()
        {
            Console.WriteLine("Enter Task Desctiption:");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Succesfully");
        }
        static void MarkComplete()
        {
            Console.WriteLine("Tasks:");
            DisplayTask();
            Console.WriteLine("Enter task number to mark as complete: ");
            int taskNumber;
            if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task mark as complete.");
            } else {
                Console.WriteLine("Invalid...");
            }
        }
        static void RemoveTask()
        {
            Console.WriteLine("Tasks:");
            DisplayTask();
            Console.WriteLine("Enter task number to remove: ");
            int taskNumber;
            if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed successfully.");
            } else {
                Console.WriteLine("Invalid...");
            }
        }
        static void ViewTask()
        {
            Console.WriteLine("Tasks:");
            DisplayTask();
        }
        static void DisplayTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No Tasks");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
    }
}

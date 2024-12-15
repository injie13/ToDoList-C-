using System;
using System.Collections.Generic;

class ToDoListaApp
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ToDoList App");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("__________________________________________");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. Delete a task");
            Console.WriteLine("3. List the tasks");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    DeleteTask();
                    break;
                case "3":
                    ListTasks();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!!!");
                    return;
                default:
                    Console.WriteLine("Invalid Input. Please Try Again");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter the task you want to add: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine($"Task '{task}' has been added to the list.");
    }

    static void DeleteTask()
    {
        ListTasks();
        if (tasks.Count == 0)
        {
            return;
        }

        Console.WriteLine("Enter the number of task youb want to delete: ");
        if (int.TryParse(Console.ReadLine(), out int taskToDelete))
        {
            taskToDelete -= 1;
            if (taskToDelete >= 0 && taskToDelete < tasks.Count)
            {
                tasks.RemoveAt(taskToDelete);
                Console.WriteLine($"Task #{taskToDelete + 1} has been removed.");
            }
            else {
                Console.WriteLine($"Task #{taskToDelete + 1} was not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input. Please enter a valid number: ");
        }
    }

    static void ListTasks()
    {
       if (tasks.Count == 0)
        {
            Console.WriteLine("There are no active tasks");
        } else
        {
            Console.WriteLine("Here are your tasks: ");
            for (int i = 0; i < tasks.Count; i++ ) {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}

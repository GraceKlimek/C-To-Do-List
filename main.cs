using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    { //Initilizes a list made to store tasks
        List<string> todoList = new List<string>();
        //Boolean is used to control the while loop.
        Boolean exit = false;

        Console.WriteLine("Welcome to your to-do list");
        while (!exit)
        {

            Console.WriteLine("Press 1 to add task, Press 2 to view tasks, Press 3 to delete tasks, Press 4 to exit");
            // reads user input
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddTask(ref todoList);
            }
            else if (choice == "2")
            {
                ViewTasks(todoList);
            }
            else if (choice == "3")
            {
                DeleteTask(ref todoList);
            }
            else if (choice == "4")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid option 1,2,3,4");
            }
        }
    }

    static void AddTask(ref List<string> todoList)
    {
        Console.Write("Enter a Task: ");
        string task = Console.ReadLine();
        todoList.Add(task);
        Console.WriteLine("Task has been added to list");
    }

    static void ViewTasks(List<string> todoList)
    {
        if (todoList.Count > 0)
        { //Displays all tasks with their appropiate index
            Console.WriteLine("Here are all your current tasks:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }
        else
        {
            Console.WriteLine("You have 0 tasks, good job!");
        }
    }

    static void DeleteTask(ref List<string> todoList)
    {
        if (todoList.Count > 0)
        {// Repeats process up above and displays all tasks with index
            Console.WriteLine("Here are all your current tasks: ");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }

            Console.Write("Enter the task number to delete: ");
            // Check if the input is a valid integer within the range of tasks
            if (int.TryParse(Console.ReadLine(), out int taskNumber) &&
                taskNumber > 0 &&
                taskNumber <= todoList.Count)
            {
                todoList.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task has been deleted");
            }
            else
            {
                Console.WriteLine("Invalid task number");
            }
        }
        else
        {
            Console.WriteLine("No tasks available to delete.");
        }
    }
}
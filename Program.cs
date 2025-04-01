using System;
using System.Collections.Generic;

namespace Estudando
{
    internal class Program
    {
        // Lista para todos os métodos
        static List<string> tasks = new List<string>();
        static string item = "";


        // Adicionar na Lista
        static void addToList()
        {
            Console.Write("\nEnter an item to add: ");
            string item = Console.ReadLine();
            tasks.Add(item);
            Console.WriteLine($"{item} added to list!");
        }

        static void viewList()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("\n The list is empty!\n");
            }

            Console.WriteLine("\n To-do list");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }

            Console.WriteLine();
        }

        static void removeItem()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("\n The list is empty!\n");
            }
            viewList();

            Console.Write("Write the name of the item you want to remove");
            string number = Console.ReadLine();

            if (tasks.Contains(number))
            {
                tasks.Remove(number);
                Console.WriteLine($"'{item}' has been removed from the list!\n");
            }
            else
            {
                Console.WriteLine("Item not found in the list!\n");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=-=-=-=-= To-do List =-=-=-=-=");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. View list");
                Console.WriteLine("3. Remove item");
                Console.WriteLine("4. Exit");
                Console.Write("> ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        addToList();
                        break;

                    case "2":
                        viewList();
                        break;

                    case "3":
                        removeItem();
                        break;

                    case "4":
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option! Please choose a valid number (1-4).\n");
                        break;

                }
            }

        }
    }
}
using System;
using System.Collections.Generic;

namespace PracticeApplication
{
    class Program
    {
        private static List<int> records = new List<int>() { 1, 2, 3, 4, 5 };
        static void Main(string[] args)
        {
            //Try writing a simple console app that stores information in the array, for example cataloging a record collection.
            //Offer the user a text menu with options to create, view, update and delete records
            //Write a simple text search on album title
            //Write a simple search on album artist
            //Offer a random suggestion for what to listen to next
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

            Console.ReadLine();
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("(1). View");
            Console.WriteLine("(2). Create");
            Console.WriteLine("(3). Update");
            Console.WriteLine("(4). Delete");
            Console.WriteLine("(5). Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                View(records);
                return true;
            }
            else if (result == "2")
            {
                //Create(List, entry);
                return true;
            }
            else if (result == "3")
            {
                //Update(List, insertionIndex, entry);
                return true;
            }
            else if (result == "4")
            {
                //Delete(List, entry);
                return true;
            }
            else if (result == "5")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void View(List<int> list)
        {
            Console.Clear();
            foreach (int item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.ReadLine();
        }

        private static void Update(List<int> list, int index, int entry) {
            list.RemoveAt(index);
            list.Insert(index, entry);
            Console.ReadLine();
        }

        private static void Create(List<int> list, int entry)
        {
            list.Add(entry);
            Console.ReadLine();
        }

        private static void Delete(List<int> list, int index)
        {
            list.RemoveAt(index);
            Console.ReadLine();
        }
    }
}

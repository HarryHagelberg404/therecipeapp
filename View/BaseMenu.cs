using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class BaseMenu
    {
        public string displayMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your CLI Recipe App! \n");
            Console.WriteLine("Press 1. To view your recipes/ingredient");
            Console.WriteLine("Press 2. To edit existing recipe/ingredient");
            Console.WriteLine("Press 3. To add a new recipe/ingredient");
            Console.WriteLine("Press 4. To exit the application");
            return Console.ReadLine();
        }
    }
}
using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class ViewMenu
    {
        public string displayMenu(List<string> recipeList)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the recipe viewer!");
            Console.WriteLine("Choose a specific recipe to get a further in depth look: \n");
            Console.WriteLine("Press 1. To go back");

            int index = 1;
            foreach(string recipe in recipeList)
            {
                index++;
                Console.WriteLine("Press " + index + ". To view recipe: " + recipe);
            }
            return Console.ReadLine();
        }

        public string showRecipe(Model.Recipe recipe)
        {
            Console.Clear();
            Console.WriteLine("Here comes an in depth look of: " + recipe.Name);
            // Present all details nicely

            // Give user option to go back
            Console.WriteLine("\nPress 1. To go back");
            return Console.ReadLine();
        }
    }
}
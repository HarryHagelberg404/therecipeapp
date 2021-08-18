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
                Console.WriteLine("Press " + index + ". to view: " + recipe);
            }
            return Console.ReadLine();
        }

        /*
        public void showRecipe(string recipe)
        {
            Console.Clear();
            Console.WriteLine("Here comes an in depth look of: " + recipe);
        }
        */
        /*
        private void addRecipe()
        {

        }

        private void getRecipe()
        {

        }

        private void TempRecipes(View.BaseMenu v_baseMenu)
        {
            Console.WriteLine("Gingerbread biscuit; 100, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
            Console.WriteLine("Pancakes; 20, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
            Console.WriteLine("Meatballs; 40, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
            Console.WriteLine(" ");
            Console.WriteLine("Press 2 To go back");
            if (UserMessage != null)
            {
                Console.WriteLine(UserMessage);
                Console.WriteLine("");
                UserMessage  = null;
            }
            int userChoice = Int16.Parse(getUserChoice());
            Console.WriteLine(userChoice);
            if (userChoice == 2)
            {
                viewMenu(v_baseMenu);
            }
            else
            {
                UserMessage = "Please enter the number 1 or 2.";
                TempRecipes(v_baseMenu);
            }   
        }*/
        
    }
}
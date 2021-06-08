using System;
using System.IO;
using System.Collections.Generic;

namespace Controller
{
    class CookBook
    {
        View.Recipes v_recipes = new View.Recipes();
        View.Ingredients v_ingredients = new View.Ingredients();
        
      
        public CookBook() 
        {
            CookBookMenu();
        }

        public void CookBookMenu() {
          Console.Clear();
          Console.WriteLine("Welcome to your digital Cookbook");
          Console.WriteLine("Press 1 to view your recipes");
          Console.WriteLine("Press 2 to add ingredients");
          Console.WriteLine("Press 3 to add recipe");
           if (v_recipes.UserMessage != null)
            {
                Console.WriteLine(v_recipes.UserMessage );
                Console.WriteLine("");
                v_recipes.UserMessage  = null;
            }

             try
            {
                int userChoice = Int16.Parse(v_recipes.getUserChoice());
                if (userChoice == 1)
                {
                    v_recipes.TempRecipes();
                }
                else if (userChoice == 2)
                {
                    v_ingredients.IngredientsMenu();
                } 
                else if (userChoice == 3)
                {
                    v_recipes.RecipesMenu();
                }
                else
                {
                    v_recipes.UserMessage  = "Please enter the number 1,2 or 3.";
                     CookBookMenu();
                }
            }
            catch (Exception)
            {
                v_recipes.UserMessage  = "Please enter a valid number instead!";
                CookBookMenu();
            }
        }


    }

}
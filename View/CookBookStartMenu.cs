using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class CookBookStartMenu
    {
        View.Recipes v_recipes = new View.Recipes();
        View.ViewRecipes v_viewRecipes = new View.ViewRecipes();
        View.Ingredients v_ingredients = new View.Ingredients();
        Database.IngredientDB m_ingredientDB = new Database.IngredientDB();
        Database.RecipesDB m_recipeDB = new Database.RecipesDB();

        private string _userMessage;

        public string UserMessage
        {
            get { return _userMessage; }
            set
            {
                _userMessage = value;
            }
        }

            public string getUserChoice()
        {
            return Console.ReadLine();
        }
          public void CookBookMenu() {
          Console.Clear();
          Console.WriteLine("Welcome to your digital Cookbook");
          Console.WriteLine("Press 1 to view your recipes");
          Console.WriteLine("Press 2 to add ingredients");
          Console.WriteLine("Press 3 to add recipe");
          Console.WriteLine("Press 4 to exit the application");
           if (UserMessage != null)
            {
                Console.WriteLine(UserMessage);
                Console.WriteLine("");
                UserMessage = null;
            }
             try
            {
                int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    v_viewRecipes.ViewRecipesMenu();
                }
                else if (userChoice == 2)
                {
                    v_ingredients.IngredientsMenu();
                } 
                else if (userChoice == 3)
                {
                    v_recipes.RecipesMenu();
                } 
                 else if (userChoice == 4)
                {
                  m_ingredientDB.saveIngredient();
                  m_recipeDB.saveRecipe();
                  System.Environment.Exit(0);
                }
                else
                {
                    UserMessage  = "Please enter the number 1,2,3 or 4.";
                    CookBookMenu();
                }
            }
            catch (Exception)
            {
                CookBookMenu();
            }
        }
    }
}
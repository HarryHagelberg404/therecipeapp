using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class CookBookMenu
    {
        View.RecipeMenu v_recipeMenu = new View.RecipeMenu();
        View.ViewRecipes v_viewRecipes = new View.ViewRecipes();
        View.Ingredients v_ingredients = new View.Ingredients();

        Controller.Ingredients c_ingredients = new Controller.Ingredients();
        Model.Recipe m_recipe = new Model.Recipe();
        Controller.Persistence c_persistence;

        private string _userMessage;

        public string UserMessage
        {
            get { return _userMessage; }
            set
            {
                _userMessage = value;
            }
        }

        public int getUserChoice()
        {
            try
            {
                return Int16.Parse(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                return 0;
            }
            catch(FormatException)
            {
                return 0;
            }
        }

        public void displayMenu() {
            Console.Clear();
            Console.WriteLine("Welcome to your CLI Recipe App! \n");
            Console.WriteLine("Press 1. To view your recipes");
            Console.WriteLine("Press 2. To edit existing recipe");
            Console.WriteLine("Press 3. To add a new recipe");
            Console.WriteLine("Press 4. To exit the application");

            // Display user message before menu choice
            if (this.UserMessage != null)
            {
                Console.WriteLine("\n" + UserMessage + "\n");
                this.UserMessage = null;
            }
            int userChoice = getUserChoice();
            if (userChoice == 1)
            {
                // Pass menu to view
                v_viewRecipes.ViewRecipesMenu(this);
            }
            else if (userChoice == 2)
            {
                v_ingredients.IngredientsMenu(this, c_ingredients);
            } 
            else if (userChoice == 3)
            {
                v_recipeMenu.displayMenu(this, m_recipe);
            } 
            else if (userChoice == 4)
            {
                this.c_persistence = new Controller.Persistence(this.c_ingredients, this.m_recipe);
                this.c_persistence.exit_and_save();
            }
            else
            {
                // Set usermessage to display
                this.UserMessage  = "Please enter the number 1, 2, 3 or 4.";
                this.displayMenu();
            }
        }
    }
}
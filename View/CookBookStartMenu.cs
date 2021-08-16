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

        Controller.Ingredients c_ingredients = new Controller.Ingredients();
        Controller.Recipes c_recipes = new Controller.Recipes();
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

        public void display_menu() {
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
                // Pass controller to view
                v_viewRecipes.ViewRecipesMenu();
            }
            else if (userChoice == 2)
            {
                v_ingredients.IngredientsMenu(c_ingredients);
            } 
            else if (userChoice == 3)
            {
                v_recipes.RecipesMenu(c_recipes);
            } 
            else if (userChoice == 4)
            {
<<<<<<< HEAD
                int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    v_viewRecipes.ViewRecipesMenu();
                }
                else if (userChoice == 2)
                {
                    v_ingredients.IngredientsMenu(c_ingredients);
                } 
                else if (userChoice == 3)
                {
                    v_recipes.RecipesMenu(c_recipes);
                } 
                 else if (userChoice == 4)
                {
                    c_ingredients.isIngredientName();
                    m_ingredientDB.saveIngredient(c_ingredients);
                    // m_recipeDB.saveRecipe(c_recipes);
                    System.Environment.Exit(1);
                }
                else
                {
                    UserMessage  = "Please enter the number 1,2,3 or 4.";
                    CookBookMenu();
                }
=======
                this.c_persistence = new Controller.Persistence(this.c_ingredients, this.c_recipes);
                this.c_persistence.exit_and_save();
>>>>>>> ce2e438ed3f187c3702ec956ef683a572a6094fc
            }
            else
            {
                // Set usermessage to display
                this.UserMessage  = "Please enter the number 1, 2, 3 or 4.";
                this.display_menu();
            }
        }
    }
}
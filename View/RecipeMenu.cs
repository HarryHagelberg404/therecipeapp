using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class RecipeMenu
    {
        Model.Persistence.RecipePersistence m_recipePersistence = new Model.Persistence.RecipePersistence();

        private string _userMessage;

        public string UserMessage
        {
            get { return _userMessage; }
            set
            {
                _userMessage = value;
            }
        }

        private  List<String> recipes = new List<String>();
        
        public RecipeMenu() {
            Console.WriteLine("Welcome to recipes");
        }

        public string getUserChoice()
        {
            return Console.ReadLine();
        }

        public void displayMenu(View.CookBookMenu v_CookBookMenu, Model.Recipe m_recipe) {
            Console.Clear();
            Console.WriteLine("Press 1 To add recipe");
            Console.WriteLine("Press 2 To go back");
            if (UserMessage != null)
            {
                Console.WriteLine(UserMessage);
                Console.WriteLine("");
                UserMessage  = null;
            }
            int userChoice = Int16.Parse(getUserChoice());
            Console.WriteLine(userChoice);
            if (userChoice == 1)
            {
                AddRecipe(v_CookBookMenu, m_recipe);
            }
            else if (userChoice == 2)
            {
                v_CookBookMenu.displayMenu();
            }
            else
            {
                UserMessage = "Please enter the number 1 or 2.";
                this.displayMenu(v_CookBookMenu, m_recipe);
            }
                  
        }
        
        private void AddRecipe(View.CookBookMenu v_CookBookMenu, Model.Recipe m_recipe) {
            Console.Clear();
            Console.WriteLine("Add your recipe");
            AddRecipeName(m_recipe);
            AddRecipePortions(m_recipe);
            AddIngredients(m_recipe);

            Console.WriteLine("Press 1 To add another recipe");
            Console.WriteLine("Press 2 To go back");
            int userChoice = Int16.Parse(getUserChoice());
            if (userChoice == 1)
            {
                AddRecipe(v_CookBookMenu, m_recipe);
            }
            else if (userChoice == 2)
            {
                v_CookBookMenu.displayMenu();
            }
        }

        private void AddRecipeName(Model.Recipe m_recipe) {
            Console.Clear();
            Console.WriteLine("Add recipe name");
            string recipeName = getUserChoice();
            m_recipe.RecipeName = recipeName;
        }

        private void AddRecipePortions(Model.Recipe m_recipe) {
            Console.Clear();
            Console.WriteLine("Add recipe portions");
            int recipePortions = Int16.Parse(getUserChoice());
            m_recipe.RecipePortions = recipePortions;
        }

        // TODO Choose ingredients from DB, and amount of ingredients
        private void AddIngredients(Model.Recipe m_recipe) {
            Console.Clear();
            Console.WriteLine("Add ingredient");
            string addIngredient = getUserChoice();
            m_recipe.RecipeIngredient = addIngredient;
            // TODO Change amountOfIngredients
            int amountOfIngredients = addIngredient.Length;
            m_recipe.RecipeIngredientAmount = amountOfIngredients;
            Console.WriteLine("Amount" + amountOfIngredients);
            AddComments(addIngredient, m_recipe);
        }

        private void AddComments(string ingredient, Model.Recipe m_recipe) {
            Console.Clear();
            Console.WriteLine("Add comment for " + ingredient);
            string addComment = getUserChoice();
            m_recipe.RecipeComment = addComment;
        }      
    }
}
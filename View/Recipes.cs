using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class Recipes
    {
        Model.Persistence.RecipePersistence m_recipePersistence = new Model.Persistence.RecipePersistence();
        private View.CookBookStartMenu v_CookBookStartMenu;

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
        public Recipes() {
            Console.WriteLine("Welcome to recipes");
        }

          public string getUserChoice()
        {
            return Console.ReadLine();
        }

        public void RecipesMenu(Controller.Recipes c_recipes) {
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
                    AddRecipe(c_recipes);
                }
                else if (userChoice == 2)
                {
                   v_CookBookStartMenu.display_menu();
                  
                }
                else
                {
                    UserMessage = "Please enter the number 1 or 2.";
                    RecipesMenu(c_recipes);
                }
                  
        }
        
        private void AddRecipe(Controller.Recipes c_recipes) {
        Console.Clear();
        Console.WriteLine("Add your recipe");
        AddRecipeName(c_recipes);
        AddRecipePortions(c_recipes);
        AddIngredients(c_recipes);

        Console.WriteLine("Press 1 To add another recipe");
        Console.WriteLine("Press 2 To go back");
        int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    AddRecipe(c_recipes);
                }
                else if (userChoice == 2)
                {
                   v_CookBookStartMenu.display_menu();
                }
     
        }

        private void AddRecipeName(Controller.Recipes c_recipes) {
        Console.Clear();
        Console.WriteLine("Add recipe name");
        string recipeName = getUserChoice();
        c_recipes.RecipeName = recipeName;
        }

        private void AddRecipePortions(Controller.Recipes c_recipes) {
        Console.Clear();
        Console.WriteLine("Add recipe portions");
        int recipePortions = Int16.Parse(getUserChoice());
        c_recipes.RecipePortions = recipePortions;
        }

        // TODO Choose ingredients from DB, and amount of ingredients
        private void AddIngredients(Controller.Recipes c_recipes) {
        Console.Clear();
        Console.WriteLine("Add ingredient");
        string addIngredient = getUserChoice();
        c_recipes.RecipeIngredient = addIngredient;
        // TODO Change amountOfIngredients
        int amountOfIngredients = addIngredient.Length;
        c_recipes.RecipeIngredientAmount = amountOfIngredients;
        Console.WriteLine("Amount" + amountOfIngredients);
        AddComments(addIngredient, c_recipes);
        }

        private void AddComments(string ingredient, Controller.Recipes c_recipes) {
        Console.Clear();
        Console.WriteLine("Add comment for " + ingredient);
        string addComment = getUserChoice();
        c_recipes.RecipeComment = addComment;
        }

       
    }
}
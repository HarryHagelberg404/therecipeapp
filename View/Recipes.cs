using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class Recipes
    {
        Model.Persistence.RecipePersistence m_recipePersistence = new Model.Persistence.RecipePersistence();
        private View.CookBookStartMenu v_CookBookStartMenu;
        Model.Recipes m_recipes = new Model.Recipes();

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

        public void RecipesMenu() {
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
                    AddRecipe();
                }
                else if (userChoice == 2)
                {
                   v_CookBookStartMenu.CookBookMenu();
                  
                }
                else
                {
                    UserMessage = "Please enter the number 1 or 2.";
                    RecipesMenu();
                }
                  
        }
        
        private void AddRecipe() {
        Console.Clear();
        Console.WriteLine("Add your recipe");
        AddRecipeName();
        AddRecipePortions();
        AddIngredients();

        Console.WriteLine("Press 1 To add another recipe");
        Console.WriteLine("Press 2 To go back");
        int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    AddRecipe();
                }
                else if (userChoice == 2)
                {
                   v_CookBookStartMenu.CookBookMenu();
                }
     
        }

        private void AddRecipeName() {
        Console.Clear();
        Console.WriteLine("Add recipe name");
        string recipeName = getUserChoice();
        m_recipes.RecipeName = recipeName;
        }

        private void AddRecipePortions() {
        Console.Clear();
        Console.WriteLine("Add recipe portions");
        int recipePortions = Int16.Parse(getUserChoice());
        m_recipes.RecipePortions = recipePortions;
        }

        // TODO Choose ingredients from DB, and amount of ingredients
        private void AddIngredients() {
        Console.Clear();
        Console.WriteLine("Add ingredient");
        string addIngredient = getUserChoice();
        m_recipes.RecipeIngredient = addIngredient;
        // TODO Change amountOfIngredients
        int amountOfIngredients = addIngredient.Length;
        m_recipes.RecipeIngredientAmount = amountOfIngredients;
        Console.WriteLine("Amount" + amountOfIngredients);
        AddComments(addIngredient);
        }

        private void AddComments(string ingredient) {
        Console.Clear();
        Console.WriteLine("Add comment for " + ingredient);
        string addComment = getUserChoice();
        m_recipes.RecipeComment = addComment;
        }

       
    }
}
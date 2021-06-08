using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class Recipes
    {
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

        public void TempRecipes() {
        Console.WriteLine("Gingerbread biscuit; 100, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
        Console.WriteLine("Pancakes; 20, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
        Console.WriteLine("Meatballs; 40, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");

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
          try
            {
                int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    AddRecipe();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Implement back to menu");
                }
                else
                {
                    UserMessage = "Please enter the number 1 or 2.";
                     RecipesMenu();
                }
            }
            catch (Exception)
            {
                UserMessage = "Please enter a valid number instead!";
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
                    Console.WriteLine("Implement back to menu Recipe Menu");
                }
     
        }

        private void AddRecipeName() {
        Console.Clear();
        Console.WriteLine("Add recipe name");
        string recipeName = getUserChoice();
        }

        private void AddRecipePortions() {
        Console.Clear();
        Console.WriteLine("Add recipe portions");
        int recipePortions = Int16.Parse(getUserChoice());
        }

        // TODO Choose ingredients from DB, and amount of ingredients
        private void AddIngredients() {
        Console.Clear();
        Console.WriteLine("Add ingredient");
        string addIngredient = getUserChoice();
        // TODO Change amountOfIngredients
        int amountOfIngredients = addIngredient.Length;
        Console.WriteLine("Amount" + amountOfIngredients);
        AddComments(addIngredient);
        }

        private void AddComments(string ingredient) {
        Console.Clear();
        Console.WriteLine("Add comment for " + ingredient);
        string addComment = getUserChoice();
        }

       
    }
}
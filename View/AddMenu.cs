using System;
using System.IO;
using System.Collections.Generic;
namespace View {

class AddMenu {

       private string _userMessage;

        private string _ingredientUnit;
        public string UserMessage
        {
            get { return _userMessage; }
            set
            {
                _userMessage = value;
            }
        }
        private  List<String> Ingredient = new List<String>();

        private List<String> Recipe = new List<string>();
      
         public string getUserChoice()
        {
            return Console.ReadLine();
        }

        public void addMenu(View.CookBook v_CookBook, Controller.Persistence c_persistence) {
        Console.Clear();

        Console.WriteLine("Press 1 To add ingredient");
        Console.WriteLine("Press 2 To add recipe");
        Console.WriteLine("Press 3 To go back");
          if (UserMessage != null)
            {
                Console.WriteLine(UserMessage);
                Console.WriteLine("");
                UserMessage = null;
            }
                int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    AddIngredients(v_CookBook);
                } else if (userChoice == 2) {
                   AddRecipe(v_CookBook);
                }
                else if (userChoice == 3)
                {   
                   v_CookBook.displayMenu();
                }
                else
                {
                    UserMessage = "Please enter the number 1 or 2.";
                    addMenu(v_CookBook, c_persistence);
                
            }
            
        }

        
        private void AddIngredients(View.CookBook v_CookBook) {
        AddIngredientName();
        AddIngredientUnit();
        AddIngredientPrice();
        Console.Clear();
        
        Console.WriteLine("Press 1 To add another ingredient");
        Console.WriteLine("Press 2 To go back");
        int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    AddIngredients(v_CookBook);
                }
                else if (userChoice == 2)
                {
                    v_CookBook.displayMenu();
                }
        }

        private void AddIngredientName() {
        Console.Clear();
        Console.WriteLine("Add your ingredient");
        Console.WriteLine("Enter name of the ingredient");
        string ingredientName = getUserChoice();
        Ingredient.Add(ingredientName);
        }

        private void AddIngredientUnit() {
        Console.Clear();
        Console.WriteLine("Enter unit");
        Console.WriteLine("Press 1 to Unit: grams");
        Console.WriteLine("Press 2 to Unit: litre");
        Console.WriteLine("Press 3 to Unit: piece");
        
            int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    _ingredientUnit = "grams";
                }
                else if (userChoice == 2)
                {   
                 _ingredientUnit = "litre";
                } else if (userChoice == 3)
                {   
                 _ingredientUnit = "piece";
                }
                else
                {
                    UserMessage = "Please enter the number 1,2 or 3.";
                    AddIngredientUnit();
                
                }
            Ingredient.Add(_ingredientUnit);
        }

        private void AddIngredientPrice() {
        Console.Clear();
        Console.WriteLine("Enter the price of the ingredient");
        string ingredientPrice = getUserChoice();
        Ingredient.Add(ingredientPrice);

        }

        private void AddRecipe(View.CookBook v_CookBook) {
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
                AddRecipe(v_CookBook);
            }
            else if (userChoice == 2)
            {
                v_CookBook.displayMenu();
            }
        }

        private void AddRecipeName() {
            Console.Clear();
            Console.WriteLine("Add recipe name");
            string recipeName = getUserChoice();
            Recipe.Add(recipeName);
        }

        private void AddRecipePortions() {
            Console.Clear();
            Console.WriteLine("Add recipe portions");
            string recipePortions = getUserChoice();
            Recipe.Add(recipePortions);
        }

        // TODO Choose ingredients from DB, and amount of ingredients
        private void AddIngredients() {
            Console.Clear();
            Console.WriteLine("Add ingredient");
            string addIngredient = getUserChoice();
            Recipe.Add(addIngredient);
            string amountOfIngredients = addIngredient.Length.ToString();
            Recipe.Add(amountOfIngredients);
            AddComments(addIngredient);
        }

        private void AddComments(string ingredient) {
            Console.Clear();
            Console.WriteLine("Add comment for " + ingredient);
            string addComment = getUserChoice();
            Recipe.Add(addComment);
        }      
    }
    }

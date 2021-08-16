using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class Ingredients
    { 

        View.CookBookStartMenu v_CookBookStartMenu;
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
      
         public string getUserChoice()
        {
            return Console.ReadLine();
        }

        public void IngredientsMenu(Controller.Ingredients c_ingredients) {
        Console.Clear();

        Console.WriteLine("Press 1 To add ingredients");
        Console.WriteLine("Press 2 To go back");
          if (UserMessage != null)
            {
                Console.WriteLine(UserMessage);
                Console.WriteLine("");
                UserMessage = null;
            }
                int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    AddIngredients(c_ingredients);
                }
                else if (userChoice == 2)
                {   
                   v_CookBookStartMenu.display_menu();
                }
                else
                {
                    UserMessage = "Please enter the number 1 or 2.";
                    IngredientsMenu(c_ingredients);
                
            }
            }

        
        private void AddIngredients(Controller.Ingredients c_ingredients) {
        AddIngredientName(c_ingredients);
        AddIngredientUnit(c_ingredients);
        AddIngredientPrice(c_ingredients);
        Console.Clear();
        
        Console.WriteLine("Press 1 To add another ingredient");
        Console.WriteLine("Press 2 To go back");
        int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    AddIngredients(c_ingredients);
                }
                else if (userChoice == 2)
                {
                    v_CookBookStartMenu.display_menu();
                }
        }

        private void AddIngredientName(Controller.Ingredients c_ingredients) {
        Console.Clear();
        Console.WriteLine("Add your ingredient");
        Console.WriteLine("Enter name of the ingredient");
        string ingredientName = getUserChoice();
        c_ingredients.IngredientName = ingredientName;
        }

        private void AddIngredientUnit(Controller.Ingredients c_ingredients) {
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
                    AddIngredientUnit(c_ingredients);
                
              }
            c_ingredients.IngredientUnit = _ingredientUnit;
        }

        private void AddIngredientPrice(Controller.Ingredients c_ingredients) {
        Console.Clear();
        Console.WriteLine("Enter the price of the ingredient");
        int ingredientPrice = Int16.Parse(getUserChoice());
        c_ingredients.IngredientPrice = ingredientPrice;

        }
    }
}
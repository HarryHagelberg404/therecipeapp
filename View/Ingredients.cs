using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class Ingredients
    {
        Model.Ingredients m_ingredients = new Model.Ingredients();

        View.CookBookStartMenu v_CookBookStartMenu;
        private string _userMessage;

        public string UserMessage
        {
            get { return _userMessage; }
            set
            {
                _userMessage = value;
            }
        }
        private  List<String> Ingredient = new List<String>();
        public Ingredients() {
            Console.WriteLine("Welcome to recipes");
        }

         public string getUserChoice()
        {
            return Console.ReadLine();
        }

        public void IngredientsMenu() {
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
                    AddIngredients();
                }
                else if (userChoice == 2)
                {   
                   v_CookBookStartMenu.CookBookMenu();
                }
                else
                {
                    UserMessage = "Please enter the number 1 or 2.";
                    IngredientsMenu();
                }
            }
        
        private void AddIngredients() {
        AddIngredientName();
        AddIngredientUnit();
        AddIngredientPrice();
        Console.Clear();
        
        Console.WriteLine("Press 1 To add another ingredient");
        Console.WriteLine("Press 2 To go back");
        int userChoice = Int16.Parse(getUserChoice());
                if (userChoice == 1)
                {
                    AddIngredients();
                }
                else if (userChoice == 2)
                {
                    v_CookBookStartMenu.CookBookMenu();
                }
        }

        private void AddIngredientName() {
        Console.Clear();
        Console.WriteLine("Add your ingredient");
        Console.WriteLine("Enter name of the ingredient");
        string ingredientName = getUserChoice();
        m_ingredients.IngredientName = ingredientName;
        }

        private void AddIngredientUnit() {
        Console.Clear();
        Console.WriteLine("Enter unit");
        string ingredientUnit = getUserChoice();
        m_ingredients.IngredientUnit = ingredientUnit;
        }

        private void AddIngredientPrice() {
        Console.Clear();
        Console.WriteLine("Enter the price of the ingredient");
        int ingredientPrice = Int16.Parse(getUserChoice());
        m_ingredients.IngredientPrice = ingredientPrice;

        }
    }
}
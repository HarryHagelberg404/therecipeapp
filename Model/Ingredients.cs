using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class Ingredients
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
        private  List<String> Ingredient = new List<String>();
        public Ingredients() {
            Console.WriteLine("Welcome to recipes");
        }

        public void TempRecipes() {
        Console.WriteLine("Gingerbread biscuit; 100, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
        Console.WriteLine("Pancakes; 20, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
        Console.WriteLine("Meatballs; 40, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");

        }

        public void IngredientsMenu() {
        Console.Clear();
        Console.WriteLine("Press 1 To add ingredients");
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
                    AddIngredients();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Implement back to menu");
                }
                else
                {
                    UserMessage = "Please enter the number 1 or 2.";
                     IngredientsMenu();
                }
            }
            catch (Exception)
            {
                UserMessage = "Please enter a valid number instead!";
                IngredientsMenu();
            }
        }
        
        private void AddIngredients() {
        Console.Clear();
        Console.WriteLine("Add your ingredient");
        Console.WriteLine("Enter name of the ingredient");
        string ingredientName = getUserChoice();
        Console.Clear();
        Console.WriteLine("Enter unit");
        string ingredientUnit = getUserChoice();
        Console.Clear();
        Console.WriteLine("Enter the price of the ingredient");
        string ingredientPrice = getUserChoice();

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
                    Console.WriteLine("Implement back to menu 2");
                }
     
        }

         public string getUserChoice()
        {
            return Console.ReadLine();
        }
    }
}
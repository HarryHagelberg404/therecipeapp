using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class ViewRecipes
    {
        View.CookBookStartMenu v_CookBookStartMenu;
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

         
        public string getUserChoice()
        {
            return Console.ReadLine();
        }

        public void ViewRecipesMenu()
        {
            Console.Clear();
            string test = this.m_recipePersistence.testString();
            Console.WriteLine(test);
            
            Console.WriteLine("Press 1 To view recipes");
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
                TempRecipes();
            }
            else if (userChoice == 2)
            {
                v_CookBookStartMenu.display_menu();      
            }
            else
            {
                UserMessage = "Please enter the number 1 or 2.";
                ViewRecipesMenu();
            }
        }

        private void addRecipe()
        {

        }

        private void getRecipe()
        {

        }

        private void TempRecipes() {
            Console.WriteLine("Gingerbread biscuit; 100, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
            Console.WriteLine("Pancakes; 20, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
            Console.WriteLine("Meatballs; 40, pieces; [1, litre, flour; 2, dl, cream; 1, spoon, cinnamon]; *Mix everything, *Wait one day, *Make figures");
            Console.WriteLine(" ");
            Console.WriteLine("Press 2 To go back");
            if (UserMessage != null)
            {
                Console.WriteLine(UserMessage);
                Console.WriteLine("");
                UserMessage  = null;
            }
            int userChoice = Int16.Parse(getUserChoice());
            Console.WriteLine(userChoice);
            if (userChoice == 2)
            {
                ViewRecipesMenu();
            }
            else
            {
                UserMessage = "Please enter the number 1 or 2.";
                TempRecipes();
            }   
        }
        
    }
}
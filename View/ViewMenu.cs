using System;
using System.IO;
using System.Collections.Generic;
namespace View {

class ViewMenu {


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

        public void viewMenu(View.CookBook v_CookBookMenu)
        {
            Console.Clear();
               
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
                TempRecipes(v_CookBookMenu);
            }
            else if (userChoice == 2)
            {
                v_CookBookMenu.displayMenu();      
            }
            else
            {
                UserMessage = "Please enter the number 1 or 2.";
                viewMenu(v_CookBookMenu);
            }
        }

        private void addRecipe()
        {

        }

        private void getRecipe()
        {

        }

        private void TempRecipes(View.CookBook v_CookBookMenu) {
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
                viewMenu(v_CookBookMenu);
            }
            else
            {
                UserMessage = "Please enter the number 1 or 2.";
                TempRecipes(v_CookBookMenu);
            }   
        }
        
    }
}
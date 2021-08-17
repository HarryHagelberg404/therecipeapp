using System;
using System.IO;
using System.Collections.Generic;
namespace View {

class EditMenu {
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
    public void editMenu (View.CookBook v_CookBookMenu, Controller.Persistence c_persistence) {
    Console.Clear();

        Console.WriteLine("Press 1 To edit recipe");
        Console.WriteLine("Press 2 To edit ingredient");
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
                    Console.WriteLine("Edit recipe");
                } else if (userChoice == 2) {
                    Console.WriteLine("Write the name of the ingredient you want to edit");
                    string ingredientName = Console.ReadLine();
                    if(c_persistence.editIngredient(ingredientName) == true) {
                      Console.WriteLine("Start edit");
                    }
                else if (userChoice == 3)
                {   
                   v_CookBookMenu.displayMenu();
                }
                else
                {
                    UserMessage = "Please enter the number 1 or 2.";
                    editMenu(v_CookBookMenu, c_persistence);
                
                }
            }
        }
    }
}
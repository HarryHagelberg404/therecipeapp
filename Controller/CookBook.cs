using System;
using System.IO;
using System.Collections.Generic;

namespace Controller
{
    class CookBook
    {
        View.BaseMenu v_baseMenu = new View.BaseMenu();

        Model.UserInput m_userInput = new Model.UserInput();

        Controller.Recipe c_recipe = new Controller.Recipe();

        public void initCookBook()
        {
            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_baseMenu.displayMenu());
            }
            // Route user to correct menu handled by the recipe controller
            switch(this.m_userInput.Choice)
            {
                case 1:
                    c_recipe.initViewRecipes();
                    break;
                case 2:
                    c_recipe.initEditRecipe();
                    break;
                case 3:
                    c_recipe.initAddRecipe();
                    break;
                case 4:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
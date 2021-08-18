using System;
using System.IO;
using System.Collections.Generic;

namespace Controller
{
    class Recipe
    {
        View.ViewMenu v_viewMenu = new View.ViewMenu();
        View.EditMenu v_editMenu = new View.EditMenu();
        View.AddMenu v_addMenu = new View.AddMenu();        

        // For navigating menus
        Model.UserInput m_userInput = new Model.UserInput();
        // For creating and editing recipes
        Model.UserRecipeInput m_userRecipeInput= new Model.UserRecipeInput();

        Controller.Persistence c_persistence = new Controller.Persistence();

        // Leave empty because of either later creation or load

        public void initViewRecipes()
        {
            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_viewMenu.displayMenu(this.c_persistence.retrieveRecipes()));
            }
            switch(this.m_userInput.Choice)
            {
                case 1:
                    break;
                default:
                    // Retrieve list of recipes from persistence controller
                    this.v_viewMenu.showRecipe(this.c_persistence.retrieveRecipe(m_userInput.Choice));
                    break;
            }
        }

        private void viewRecipe()
        {

        }

        public void initEditRecipe()
        {
            
        }

        private void editRecipe()
        {

        }

        public void initAddRecipe()
        {
            // Show menu
            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_addMenu.displayMenu());
            }
            switch(this.m_userInput.Choice)
            {
                case 1:
                    this.addRecipe();
                    break;
                case 2:
                    break;
            }
        }

        private void addRecipe()
        {
            Model.Recipe recipe = new Model.Recipe();

            // Adding recipe name
            while(this.m_userRecipeInput.Value == null)
            {
                this.m_userRecipeInput.validate(this.v_addMenu.addRecipeName(), false);
            }
            recipe.Name = this.m_userRecipeInput.Value;
            this.m_userRecipeInput.Value = null;

            // Adding recipe portions
            while(this.m_userRecipeInput.Value == null)
            {
                this.m_userRecipeInput.validate(this.v_addMenu.addRecipePortions(), true);
            }
            Console.WriteLine(this.m_userRecipeInput.Value);

            // Add value to model
            this.m_userRecipeInput.Value = null;
        }
    }
}
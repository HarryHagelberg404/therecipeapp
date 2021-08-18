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
        
        public void initViewRecipes()
        {
            this.m_userInput.resetChoice();

            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_viewMenu.displayMenu(this.c_persistence.retrieveRecipes()));
            }
            switch(this.m_userInput.Choice)
            {
                case 1:
                    // Return to previous menu
                    return;
                default:
                    // Retrieve specific recipe based on chosen index
                    // Reduce validated userInput by 2 to match 0-based index of recipe list
                    this.viewRecipe(this.c_persistence.retrieveRecipe(this.m_userInput.Choice - 2));
                    break;
            }

            // When user returns present them once more
            this.m_userInput.resetChoice();
            this.initViewRecipes();
        }

        private void viewRecipe(Model.Recipe recipe)
        {
            this.m_userInput.resetChoice();

            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_viewMenu.showRecipe(recipe));
            }
            switch(this.m_userInput.Choice)
            {
                case 1:
                    return;
            }
        }

        public void initEditRecipe()
        {
            
        }

        private void editRecipe()
        {

        }

        public void initAddRecipe()
        {
            this.m_userInput.resetChoice();

            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_addMenu.displayMenu());
            }
            switch(this.m_userInput.Choice)
            {
                case 1:
                    return;
                case 2:
                    this.addRecipe();
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

        // Methods that could be reused multiple times in control flow
        private void addIngredient()
        {

        }
    }
}
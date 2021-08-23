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

        Model.Persistence m_persistence = new Model.Persistence();
        
        public void initViewRecipes()
        {
            this.m_userInput.resetChoice();

            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_viewMenu.displayMenu(this.m_persistence.retrieveRecipes()));
            }
            switch(this.m_userInput.Choice)
            {
                case 1:
                    // Return to previous menu
                    return;
                default:
                    // Retrieve specific recipe based on chosen index
                    // Reduce validated userInput by 2 to match 0-based index of recipe list
                    this.viewRecipe(this.m_persistence.retrieveRecipe(this.m_userInput.Choice - 2));
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
                    // Return to previous menu
                    return;
                case 2:
                    this.addRecipe();
                    break;
            }

            this.initAddRecipe();
        }

        private void addRecipe()
        {
            // TODO: BRYT UT FUNKTIONENS OLIKA DELAR

            // Reseting input as a precausion
            this.m_userInput.resetChoice();
            this.m_userRecipeInput.resetValue();
            Model.Recipe m_recipe = new Model.Recipe();

            // Adding recipe name
            while(this.m_userRecipeInput.Value == null)
            {
                this.m_userRecipeInput.Value = this.v_addMenu.addRecipeName();
            }
            m_recipe.Name = this.m_userRecipeInput.Value;
            this.m_userRecipeInput.resetValue();

            // Adding recipe portions
            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_addMenu.addRecipePortions());
            }
            m_recipe.Portions = this.m_userInput.Choice;
            this.m_userInput.resetChoice();
            
            // Adding ingredients which is a list object without max amount
            // Thus requires another form control structure

            while (this.m_userRecipeInput.Value != "exit" || m_recipe.Ingredients.Count == 0)
            {
                bool isFirstIngredient;
                if (m_recipe.Ingredients.Count == 0) isFirstIngredient = true;
                else isFirstIngredient = false;

                this.m_userRecipeInput.Value = this.v_addMenu.addIngredientName(m_recipe.Ingredients, isFirstIngredient);
                if (this.m_userRecipeInput.Value != "exit")
                {
                    // Route the user to the ingredient creation while loop
                    m_recipe.Ingredients.Add(this.addIngredientInternals(this.m_userRecipeInput.Value));
                } 
            }
            this.m_userRecipeInput.resetValue();

            // Adding a recipe comment
            while (this.m_userRecipeInput.Value == null)
            {
                this.m_userRecipeInput.Value = this.v_addMenu.addRecipeComment();
            }
            m_recipe.Comment = this.m_userRecipeInput.Value;
            this.m_userRecipeInput.resetValue();

            // Adding instructions which is a list object without max amount
            // Thus requires another form control structure
            while (this.m_userRecipeInput.Value != "exit" || m_recipe.Instructions.Count == 0)
            {
                bool isFirstInstruction;
                if (m_recipe.Instructions.Count == 0) isFirstInstruction = true;
                else isFirstInstruction = false;

                this.m_userRecipeInput.Value = this.v_addMenu.addRecipeInstruction(m_recipe.Instructions, isFirstInstruction);
                if (this.m_userRecipeInput.Value != "exit")
                {
                    // Route the user to the ingredient creation while loop
                    m_recipe.Instructions.Add(this.m_userRecipeInput.Value);  
                }
            }
            this.m_userRecipeInput.resetValue();

            this.m_persistence.saveRecipe(m_recipe);
        }

        // Methods that could be reused multiple times in control flow
        private Model.Ingredient addIngredientInternals(string ingredientName)
        {
            this.m_userRecipeInput.resetValue();

            // Initialize ingredient
            Model.Ingredient m_ingredient = new Model.Ingredient();
            m_ingredient.Name = ingredientName;

            // Fill in internals of ingredient
            // Amount
            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_addMenu.addIngredientAmount());
            }
            m_ingredient.Amount = this.m_userInput.Choice;
            this.m_userInput.resetChoice();

            // Unit
            while(this.m_userRecipeInput.Value == null)
            {
                this.m_userRecipeInput.Value = this.v_addMenu.addIngredientUnit();
            }
            m_ingredient.Unit = m_userRecipeInput.Value;
            this.m_userRecipeInput.resetValue();

            // Price
            while(this.m_userInput.Choice == 0)
            {
                this.m_userInput.validate(this.v_addMenu.addIngredientPrice());
            }
            m_ingredient.Price = this.m_userInput.Choice;
            this.m_userInput.resetChoice();

            // Return ingredient to add into recipe model
            return m_ingredient;
        }
    }
}
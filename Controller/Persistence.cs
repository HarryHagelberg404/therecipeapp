using System;
using System.IO;
using System.Collections.Generic;

namespace Controller
{
    class Persistence
    {
        Controller.Ingredients c_ingredients;

        Model.Recipe m_recipe;
        Database.IngredientDB m_ingredientDB = new Database.IngredientDB();
        Database.RecipesDB m_recipeDB = new Database.RecipesDB();
      
        public Persistence(Controller.Ingredients ingredients, Model.Recipe recipe) 
        {
            this.c_ingredients = ingredients;
            this.m_recipe = recipe;
        }

        public void exit_and_save()
        {
            // Anrop till controller -> dummy_save, anrop till modellen sker från controller istället´
            m_ingredientDB.saveIngredient(c_ingredients);
            m_recipeDB.saveRecipe(m_recipe);
            System.Environment.Exit(1);
        }
    }

}
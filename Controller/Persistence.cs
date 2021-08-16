using System;
using System.IO;
using System.Collections.Generic;

namespace Controller
{
    class Persistence
    {
        Controller.Ingredients c_ingredients;
        Controller.Recipes c_recipes;

        Database.IngredientDB m_ingredientDB = new Database.IngredientDB();
        Database.RecipesDB m_recipeDB = new Database.RecipesDB();
      
        public Persistence(Controller.Ingredients ingredients, Controller.Recipes recipes) 
        {
            this.c_ingredients = ingredients;
            this.c_recipes = recipes;
        }

        public void exit_and_save()
        {
            // Anrop till controller -> dummy_save, anrop till modellen sker från controller istället´
            m_ingredientDB.saveIngredient(c_ingredients);
            m_recipeDB.saveRecipe(c_recipes);
            System.Environment.Exit(1);
        }
    }

}
using System;
using System.IO;
using System.Collections.Generic;

namespace Database
{
    class RecipesDB
    {
          private string _dbFileName = "RecipeDB.txt";

         public void saveRecipe(Controller.Recipes c_recipes) {
       
            if (!File.Exists(_dbFileName) && c_recipes.RecipeName.Length > 1)
            {
                StreamWriter sw = File.CreateText(_dbFileName);
            {
                        sw.WriteLine($"Recipe:{c_recipes.RecipeName}, Portions:{c_recipes.RecipePortions}, Ingredients:{c_recipes.RecipeIngredient}, IngredientAmount:{c_recipes.RecipeIngredientAmount}, Comments:{c_recipes.RecipeComment}");   
            }
                        sw.Close();
            }
            else if (File.Exists(_dbFileName) && c_recipes.RecipeName.Length > 1)
            {
                StreamWriter sw = File.AppendText(_dbFileName );
                {
     
                   sw.WriteLine($"Recipe:{c_recipes.RecipeName}, Portions:{c_recipes.RecipePortions}, Ingredients:{c_recipes.RecipeIngredient}, IngredientAmount:{c_recipes.RecipeIngredientAmount}, Comments:{c_recipes.RecipeComment}");   

                }
                 sw.Close();   
            }
        }

    }
}
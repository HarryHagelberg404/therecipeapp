using System;
using System.IO;
using System.Collections.Generic;

namespace Database
{
    class RecipesDB
    {
         Model.Recipes m_recipes;
          private string _dbFileName = "RecipeDB.txt";

         public void saveRecipe() {
       
            if (!File.Exists(_dbFileName))
            {
                StreamWriter sw = File.CreateText(_dbFileName);
            {
                        sw.WriteLine($"Recipe:{m_recipes.RecipeName}, Portions:{m_recipes.RecipePortions}, Ingredients:{m_recipes.RecipeIngredient}, IngredientAmount:{m_recipes.RecipeIngredientAmount}, Comments:{m_recipes.RecipeComment}");   
            }
                        sw.Close();
            }
            else
            {
                StreamWriter sw = File.AppendText(_dbFileName);
                {
     
                   sw.WriteLine($"Recipe:{m_recipes.RecipeName}, Portions:{m_recipes.RecipePortions}, Ingredients:{m_recipes.RecipeIngredient}, IngredientAmount:{m_recipes.RecipeIngredientAmount}, Comments:{m_recipes.RecipeComment}");   

                }
                 sw.Close();   
            }
        }

    }
}
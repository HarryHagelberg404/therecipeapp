using System;
using System.IO;
using System.Collections.Generic;

namespace Database
{
    class RecipesDB
    {
        private string _dbFileName = "RecipeDB.txt";

        public void saveRecipe(Model.Recipe m_recipe) {
       
            if (!File.Exists(_dbFileName) && m_recipe.RecipeName.Length > 1)
            {
                StreamWriter sw = File.CreateText(_dbFileName);
            {
                sw.WriteLine($"Recipe:{m_recipe.RecipeName}, Portions:{m_recipe.RecipePortions}, Ingredients:{m_recipe.RecipeIngredient}, IngredientAmount:{m_recipe.RecipeIngredientAmount}, Comments:{m_recipe.RecipeComment}");   
            }
                sw.Close();
            }
            else if (File.Exists(_dbFileName) && m_recipe.RecipeName.Length > 1)
            {
                StreamWriter sw = File.AppendText(_dbFileName );
                {
     
                   sw.WriteLine($"Recipe:{m_recipe.RecipeName}, Portions:{m_recipe.RecipePortions}, Ingredients:{m_recipe.RecipeIngredient}, IngredientAmount:{m_recipe.RecipeIngredientAmount}, Comments:{m_recipe.RecipeComment}");   

                }
                sw.Close();   
            }
        }

    }
}
using System;
using System.IO;
using System.Collections.Generic;
namespace Model
{
    class Persistence {
    private string _dbFileIngredient = "IngredientDB.txt";

    private string _dbFileRecipe = "RecipeDB.txt";
        
         public void saveIngredient(Model.Recipe m_recipe) {
       
            if (!File.Exists(_dbFileIngredient) && m_recipe.IngredientName.Length > 1)
            {
                StreamWriter sw = File.CreateText(_dbFileIngredient);
            {
                        sw.WriteLine($"Name:{m_recipe.IngredientName}, Unit:{m_recipe.IngredientUnit}, Price:{m_recipe.IngredientPrice} Kr");   
            }
                        sw.Close();
            }
            else if (File.Exists(_dbFileIngredient) && m_recipe.IngredientName.Length > 1)
            {
                StreamWriter sw = File.AppendText(_dbFileIngredient);
                {
     
                    sw.WriteLine($"Name:{m_recipe.IngredientName}, Unit:{m_recipe.IngredientUnit}, Price:{m_recipe.IngredientPrice} Kr"); 

                }
                    sw.Close();   
            }
        }

         public void saveRecipe(Model.Recipe m_recipe) {
       
            if (!File.Exists(_dbFileRecipe) && m_recipe.RecipeName.Length > 1)
            {
                StreamWriter sw = File.CreateText(_dbFileRecipe);
            {
                sw.WriteLine($"Recipe:{m_recipe.RecipeName}, Portions:{m_recipe.RecipePortions}, Ingredients:{m_recipe.RecipeIngredient}, IngredientAmount:{m_recipe.RecipeIngredientAmount}, Comments:{m_recipe.RecipeComment}");   
            }
                sw.Close();
            }
            else if (File.Exists(_dbFileRecipe) && m_recipe.RecipeName.Length > 1)
            {
                StreamWriter sw = File.AppendText(_dbFileRecipe);
                {
     
                   sw.WriteLine($"Recipe:{m_recipe.RecipeName}, Portions:{m_recipe.RecipePortions}, Ingredients:{m_recipe.RecipeIngredient}, IngredientAmount:{m_recipe.RecipeIngredientAmount}, Comments:{m_recipe.RecipeComment}");   

                }
                sw.Close();   
            }
        }

    }
}
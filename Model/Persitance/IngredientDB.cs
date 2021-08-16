using System;
using System.IO;
using System.Collections.Generic;

namespace Database
{
    class IngredientDB
    {
        private string _dbFileName = "IngredientDB.txt";
        
         public void saveIngredient(Controller.Ingredients c_ingredient) {
       
            if (!File.Exists(_dbFileName) && c_ingredient.IngredientName.Length > 1)
            {
                StreamWriter sw = File.CreateText(_dbFileName);
            {
                        sw.WriteLine($"Name:{c_ingredient.IngredientName}, Unit:{c_ingredient.IngredientUnit}, Price:{c_ingredient.IngredientPrice} Kr");   
            }
                        sw.Close();
            }
            else if (File.Exists(_dbFileName) && c_ingredient.IngredientName.Length > 1)
            {
                StreamWriter sw = File.AppendText(_dbFileName);
                {
     
                    sw.WriteLine($"Name:{c_ingredient.IngredientName}, Unit:{c_ingredient.IngredientUnit}, Price:{c_ingredient.IngredientPrice} Kr"); 

                }
                    sw.Close();   
            }
        }

    }
}
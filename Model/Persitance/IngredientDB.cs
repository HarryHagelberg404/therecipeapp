using System;
using System.IO;
using System.Collections.Generic;

namespace Database
{
    class IngredientDB
    {
        private string _dbFileName = "IngredientDB.txt";
        
         public void saveIngredient(Controller.Ingredients c_ingredient) {
       
            if (!File.Exists(_dbFileName))
            {
                StreamWriter sw = File.CreateText(_dbFileName);
            {
                        sw.WriteLine($"Name:{c_ingredient.IngredientName}, Unit:{c_ingredient.IngredientUnit}, Price:{c_ingredient.IngredientPrice} Kr");   
            }
                        sw.Close();
            }
            else
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
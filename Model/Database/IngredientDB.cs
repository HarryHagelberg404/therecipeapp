using System;
using System.IO;
using System.Collections.Generic;

namespace Database
{
    class IngredientDB
    {
        Model.Ingredients m_ingredient = new Model.Ingredients();
          private string _dbFileName = "IngredientDB.txt";

         public void saveIngredient() {
       
            if (!File.Exists(_dbFileName))
            {
                StreamWriter sw = File.CreateText(_dbFileName);
            {
                        sw.WriteLine($"Name:{m_ingredient.IngredientName}, Unit:{m_ingredient.IngredientUnit}, Price:{m_ingredient.IngredientPrice}");   
            }
                        sw.Close();
            }
            else
            {
                StreamWriter sw = File.AppendText(_dbFileName);
                {
     
                    sw.WriteLine($"Name:{m_ingredient.IngredientName}, Unit:{m_ingredient.IngredientUnit}, Price:{m_ingredient.IngredientPrice}"); 

                }
                    sw.Close();   
            }
        }

    }
}
using System;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class Persistence
    {
        Model.Recipe m_recipe;

        private string _location = "./Recipes";
        private string _directoryName;

        public List<string> retrieveRecipes()
        {
            List<string> recipeList = new List<string>();

            // Fill with all recipe names inside ./Recipes directory
            var directories = Directory.GetDirectories(this._location);
            foreach(string directory in directories)
            {
                // Current layout of directory = ./Recipe/xxx
                // Thus need to retrive recipe name after second "/"
                recipeList.Add(directory.Substring(directory.LastIndexOf("/") + 1));
            }
            return recipeList;
        }

        public Model.Recipe retrieveRecipe(int indexOfRecipe)
        {
            string recipeName = this.retrieveRecipes()[indexOfRecipe];
            string[] fileArray = Directory.GetFiles(this._location + "/" + recipeName);
            foreach(string file in fileArray)
            {
                Console.WriteLine(file);
            }
            Console.ReadLine();

            // Load directory into model

            // Return model
            Model.Recipe recipe = new Model.Recipe();
            recipe.Name = "SPAGHETTT";
            return recipe;
        }
        /*
        private string retrieveValueFromFile()
        {

        }

        private string[] retrieveValuesFromFile()
        {

        }
        */
        public bool saveRecipe(Model.Recipe recipe)
        {
            return true;
        }
    /*
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
        */
    }
}
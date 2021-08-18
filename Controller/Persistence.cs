using System;
using System.IO;
using System.Collections.Generic;

namespace Controller
{
    class Persistence
    {
    
        Model.Recipe m_recipe;

        Model.Persistence m_persistence;

        private string _dbFileName = "IngredientDB.txt";

        public List<string> retrieveRecipes()
        {
            List<string> recipeList = new List<string>();
            recipeList.Add("Bacon");
            recipeList.Add("Spaghet");
            recipeList.Add("Hamburga");
            return recipeList;
        }

        public string retrieveRecipe(int indexOfRecipe)
        {
            return "Bacon";
        }
      
        /*
        public Persistence(Model.Recipe m_recipe) 
        {
            this.m_recipe = m_recipe;
        }

        public void exit_and_save()
        {
            // Anrop till controller -> dummy_save, anrop till modellen sker från controller istället´
            m_persistence.saveIngredient(this.m_recipe);
            m_persistence.saveRecipe(this.m_recipe);
            System.Environment.Exit(1);
        }

    // Checks IngredientDB for duplicates and make the IngredientName to an empty string when it already exists.
    public void isIngredientName () {

        if(File.Exists(_dbFileName)) {
        string[] lines = System.IO.File.ReadAllLines("IngredientDB.txt");
        foreach (string line in lines)
        {
            // Use a tab to indent each line of the file.
            Console.WriteLine("\t" + line);
            Console.WriteLine(line.Split(':' , ',')[1]);
            if(this.m_recipe.IngredientName == line.Split(':' , ',')[1]) {
             this.m_recipe.IngredientName = " ";
            } 
        }
        }
    }

    // Edit ingredient
    public bool editIngredient (string ingredient) {
     if(File.Exists(_dbFileName)) {
        string[] lines = System.IO.File.ReadAllLines("IngredientDB.txt");
        foreach (string line in lines)
        {
            // Use a tab to indent each line of the file.
            Console.WriteLine("\t" + line);
            Console.WriteLine(line.Split(':' , ',')[1]);
            if(ingredient == line.Split(':' , ',')[1]) {
             return true;
            } 
            else {
            return false;
            }
        }
        }
        return false;
    }

    // Remove ingredient
    public void removeIngredient () {
    
    }*/
      
    }

}
using System;
using System.IO;
using System.Collections.Generic;

namespace Controller
{

    class Ingredients
    {
        private string _dbFileName = "IngredientDB.txt";
        private string _ingredientName;

        private string _ingredientUnit;

        private int _ingredientPrice;
        public string IngredientName {
        get {return _ingredientName;} 
        set {_ingredientName = value;}
        }

        public string IngredientUnit {
        get {return _ingredientUnit;} 
        set {_ingredientUnit = value;}
        }

        public int IngredientPrice {
        get {return _ingredientPrice;} 
        set {_ingredientPrice = value;}
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
            if(IngredientName == line.Split(':' , ',')[1]) {
             IngredientName = " ";
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
    
    }

    }


}
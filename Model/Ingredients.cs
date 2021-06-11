using System;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class Ingredients
    {
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

    }
}
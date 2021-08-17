using System;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class Recipe
    {  
        private string _recipeName;

        private int _recipePortions;

        private string _recipeIngredients;

        private int _recipeIngredientsAmount;

        private string _recipeIngredientsComment;

        private List<string> _recipeInstructions;

        private string _recipeComment;

        private string _ingredientName;

        private string _ingredientUnit;

        private int _ingredientPrice;
        
        public string RecipeName {
        get {return _recipeName;} 
        set {_recipeName = value;}
        }

        public int RecipePortions {
        get {return _recipePortions;} 
        set {_recipePortions = value;}
        }

        public string RecipeIngredient {
        get {return _recipeIngredients;} 
        set {_recipeIngredients = value;}
        }

        public int RecipeIngredientAmount {
        get {return _recipeIngredientsAmount;} 
        set {_recipeIngredientsAmount = value;}}

        public string RecipeComment {
        get {return _recipeComment;} 
        set {_recipeComment = value;}
        }

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

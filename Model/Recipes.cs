using System;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class Recipes
    {  
        private string _recipeName;

        private int _recipePortions;

        private string _recipeIngredients;

        private int _recipeIngredientsAmount;

        private string _recipeComment;
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
    }
}


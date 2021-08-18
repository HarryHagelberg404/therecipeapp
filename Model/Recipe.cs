using System;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class Recipe
    {  
        private string _name;
        private int _portions;
        private List<Ingredient> _ingredients;
        private string _comment;
        private List<string> _instructions;
        
        public string Name
        {
            get { return _recipeName; } 
            set { _recipeName = value; }
        }

        public int Portions
        {
            get { return _portions; } 
            set { _portions = value; }
        }

        public List<Ingredient> Ingredient
        {
            get { return _ingredients; } 
            set { _recipeIngredients.Add(value); }
        }

        public string Comment
        {
            get { return _comment; } 
            set {_comment = value; }
        }

        public List<string> Instructions
        {
            get { return _instructions; }
            set { _instructions.Add(value); }
        }
    }
}

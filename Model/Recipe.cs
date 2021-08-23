using System;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class Recipe
    {  
        private string _name;
        private int _portions;
        private List<Ingredient> _ingredients = new List<Ingredient>();
        private string _comment;
        private List<string> _instructions = new List<string>();
        
        public string Name
        {
            get { return this._name; } 
            set { this._name = value; }
        }

        public int Portions
        {
            get { return this._portions; } 
            set { this._portions = value; }
        }

        public List<Ingredient> Ingredients
        {
            get { return this._ingredients; }
        }

        public string Comment
        {
            get { return this._comment; } 
            set { this._comment = value; }
        }

        public List<string> Instructions
        {
            get { return this._instructions; }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class Ingredient
    {
        private string _name;
        private int _amount;
        private string _unit;
        private int _price;

        public string Name
        {
            get { return _name; } 
            set { _name = value; }
        }

        public int Amount
        {
            get { return _amount; } 
            set { _amount = value;}
        }

        public string Unit
        {
            get { return _unit; } 
            set { _unit = value; }
        }

        public int Price
        {
            get { return _price; } 
            set { _price = value; }
        }
    }
}
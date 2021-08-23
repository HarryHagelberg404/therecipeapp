using System;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class UserRecipeInput
    {
        private string _value = null;

        public string Value
        {
            get { return this._value; }
            set
            {
                try
                {
                    this._value = value;
                }
                catch (ArgumentException)
                {
                    this._value = null;
                }
            }
        }

        // To increase clarity when used
        public void resetValue()
        {
            Value = null;
        }
    }
}
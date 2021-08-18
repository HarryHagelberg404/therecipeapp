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
            set { this._value = value; }
        }

        // Bad practice but works for now :/
        public void validate(string value, bool isNumeric)
        {
            if (isNumeric)
            {
                try
                {
                    // Force exception if user does not enter numeric value
                    int convertedInput = Convert.ToInt32(value);
                    this.Value = convertedInput.ToString();
                }
                catch (ArgumentException)
                {
                    this.Value = null;
                }
                catch(FormatException)
                {
                    this.Value = null;
                }
            }
            else
            {
                this.Value = value;
            }
        }
    }
}
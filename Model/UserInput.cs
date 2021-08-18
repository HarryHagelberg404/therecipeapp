using System;
using System.IO;
using System.Collections.Generic;

namespace Model
{
    class UserInput
    {
        private int _choice = 0;

        public int Choice
        {
            get { return this._choice; }
            set { this._choice = value; }
        }

        // Bad practice but works for now :/
        public void validate(string value)
        {
            try
            {
                this.Choice = Convert.ToInt32(value);
            }
            catch (ArgumentException)
            {
                this.Choice = 0;
            }
            catch(FormatException)
            {
                this.Choice = 0;
            }
        }
    }
}
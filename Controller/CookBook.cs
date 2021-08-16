using System;
using System.IO;
using System.Collections.Generic;

namespace Controller
{
    class CookBook
    {
        View.CookBookMenu v_CookBookMenu = new View.CookBookMenu();
      
        public CookBook() 
        {
            v_CookBookMenu.displayMenu();
        }
    }

}
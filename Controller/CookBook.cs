using System;
using System.IO;
using System.Collections.Generic;

namespace Controller
{
    class CookBook
    {
        View.CookBookStartMenu v_CookBookStartMenu = new View.CookBookStartMenu();
      
      
        public CookBook() 
        {
           v_CookBookStartMenu.CookBookMenu();
        }

      
    }

}
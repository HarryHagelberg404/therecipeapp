using System;

namespace therecipeapp
{
    class Program
    {
        static void Main(string[] args)
        {
            View.CookBook cookBook = new View.CookBook();
            cookBook.displayMenu();
        }
    }
}

using System;

namespace therecipeapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init controller to handle flow of proccesses
            Controller.CookBook cookBook = new Controller.CookBook();
            cookBook.initCookBook();
        }
    }
}

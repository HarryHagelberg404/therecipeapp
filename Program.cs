using System;

namespace therecipeapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Persistence m_persistence = new Model.Persistence();
            m_persistence.retrieveRecipe(1);
            // Init controller to handle flow of proccesses
            Controller.CookBook cookBook = new Controller.CookBook();
            cookBook.initCookBook();
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;

namespace View
{
    class AddMenu
    {
        // Steps of creating a recipe
        public string displayMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the recipe creator! \n");
            Console.WriteLine("Press 1. To go back");
            Console.WriteLine("Press 2. To create a new recipe");
            return Console.ReadLine();
        }

        public string addRecipeName()
        {
            Console.Clear();
            Console.WriteLine("Please enter the name of your new recipe: \n");
            return Console.ReadLine();
        }

        public string addRecipePortions()
        {
            Console.Clear();
            Console.WriteLine("Please enter the number of portions of your new recipe: \n");
            return Console.ReadLine();
        }

        public string addIngredientName(List<Model.Ingredient> ingredients, bool isFirstIngredient)
        {
            if (isFirstIngredient)
            {
                Console.Clear();
                Console.WriteLine("Total of ingredients added: 0");
                Console.WriteLine("Please enter the name of your first ingredient:\n");
                return Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Total of ingredients added: " + ingredients.Count);
                Console.WriteLine("Please enter precisely 'exit' if you are done with all ingredients:");
                Console.WriteLine("Or");
                Console.WriteLine("Please enter the name of your new ingredient:\n");
                return Console.ReadLine();
            }
        }

        public string addIngredientAmount()
        {
            Console.Clear();
            Console.WriteLine("Please enter the numeric amount of your new ingredient:\n");
            return Console.ReadLine();
        }

        public string addIngredientUnit()
        {
            Console.Clear();
            Console.WriteLine("Please enter the unit of measure of your new ingredient:\n");
            return Console.ReadLine();
        }

        public string addIngredientPrice()
        {
            Console.Clear();
            Console.WriteLine("Please enter the numeric price of your new ingredient:\n");
            return Console.ReadLine();
        }

        public string addRecipeComment()
        {
            Console.Clear();
            Console.WriteLine("Please write and submit a comment for your recipe ex:");
            Console.WriteLine("ex: The difficulty of the recipe, How good it tastes etc.\n");
            return Console.ReadLine();
        }

        public string addRecipeInstruction(List<string> instructions, bool isFirstInstruction)
        {
            if (isFirstInstruction)
            {
                Console.Clear();
                Console.WriteLine("Total of instructions added: 0");
                Console.WriteLine("Please enter the name of your first ingredient:\n");
                return Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Total of instructions added: " + instructions.Count);
                Console.WriteLine("Please enter precisely 'exit' if you are done with all instructions:");
                Console.WriteLine("Or");
                Console.WriteLine("Please enter the name of your new instructions:\n");
                return Console.ReadLine();
            }
        }  
    }
}

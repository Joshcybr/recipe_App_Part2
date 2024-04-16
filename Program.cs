using System;

namespace recipe_App
{
    public class Recipe
    {
        public string Name { get; set; }
        public string[] Ingredients { get; set; }
        public string[] Steps { get; set; }
    }

    class Program
    {

        public void Menu()
        {
            Recipe recipe = new Recipe();
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome, " + name + ", to the recipe app");
            Console.WriteLine("Let's get cooking!");

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear all data");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EnterRecipeDetails(recipe);
                        break;
                    case "2":
                        DisplayRecipe(recipe);
                        break;
                    case "3":
                        Scale(recipe);
                        break;
                    case "4":
                        ResetQuantities(recipe);
                        break;
                    case "5":
                        ClearData(recipe);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
       


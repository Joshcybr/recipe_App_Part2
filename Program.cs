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
        static void Main(string[] args)
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

        static void EnterRecipeDetails(Recipe recipe)
        {
            Console.WriteLine("What is the name of your dish?");
            recipe.Name = Console.ReadLine();

            Console.WriteLine("How many ingredients are there?");
            int ingredientsCount = int.Parse(Console.ReadLine());
            recipe.Ingredients = new string[ingredientsCount];

            for (int i = 0; i < ingredientsCount; i++)
            {
                Console.WriteLine("Enter ingredient " + (i + 1) + ":");
                recipe.Ingredients[i] = Console.ReadLine();
            }

            Console.WriteLine("How many steps are there?");
            int stepsCount = int.Parse(Console.ReadLine());
            recipe.Steps = new string[stepsCount];

            for (int i = 0; i < stepsCount; i++)
            {
                Console.WriteLine("Enter step " + (i + 1) + ":");
                recipe.Steps[i] = Console.ReadLine();
            }
        }








        static void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine("Dish name: " + recipe.Name);
            Console.WriteLine("YOU WILL NEED THE FOLLOWING INGREDIENTS:");
            for (int i = 0; i < recipe.Ingredients.Length; i++)
            {
                Console.WriteLine("- " + recipe.Ingredients[i]);
            }
            Console.WriteLine("HERE ARE THE STEPS TO FOLLOW:");
            foreach (var step in recipe.Steps)
            {
                Console.WriteLine("- " + step);
            }
        }



        static void Scale(Recipe recipe)
        {
            Console.WriteLine("Enter the scale factor:");
            double scale = double.Parse(Console.ReadLine());

            Console.WriteLine("Scaled ingredients:");
            for (int i = 0; i < recipe.Ingredients.Length; i++)
            {
                Console.WriteLine($"Enter quantity for {recipe.Ingredients[i]}:");
                double quantity = double.Parse(Console.ReadLine());
                double scaledQuantity = quantity * scale;
                Console.WriteLine($"{scaledQuantity} {recipe.Ingredients[i]}");
            }
            Console.WriteLine("Recipe scaled successfully!");
        }


        //let



        static void ResetQuantities(Recipe recipe)
        {
            // do this shit
        }

        static void ClearData(Recipe recipe)
        {
            recipe.Name = null;
            recipe.Ingredients = null;
            recipe.Steps = null;

            Console.WriteLine(" Cleaned");
        }
    }
}



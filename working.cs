using System;

namespace recipe_App
{
    public class working
    {
        public class Recipe
        {
            public string Name { get; set; }
            public string[] Ingredients { get; set; }
            public string[] Steps { get; set; }

            public Recipe()
            {
                Name = null;
                Ingredients = null;
                Steps = null;
            }
        }

        public void Menu(Recipe recipe)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome, " + name + ", to the recipe app");
            Console.WriteLine("\n");
            Console.WriteLine("Let's get cooking!");
            Console.WriteLine("\n");
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
                       Environment.Exit(0);         
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

        public void EnterRecipeDetails(Recipe recipe)
        {
            Console.WriteLine("What is the name of your dish?");
            recipe.Name = Console.ReadLine();
            Console.WriteLine("\n");
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

        public void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine("Dish name: " + recipe.Name);
            Console.WriteLine("\n");
            Console.WriteLine("YOU WILL NEED THE FOLLOWING INGREDIENTS:");
            for (int i = 0; i < recipe.Ingredients.Length; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("- " + recipe.Ingredients[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("HERE ARE THE STEPS TO FOLLOW:");
            foreach (var step in recipe.Steps)
            {
                Console.WriteLine("- " + step);
            }
        }

        public void Scale(Recipe recipe)
        {
            Console.WriteLine("Enter the scale factor:");
            double scale = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Scaled ingredients:");
            for (int i = 0; i < recipe.Ingredients.Length; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Enter quantity for {recipe.Ingredients[i]}:");
                double quantity = double.Parse(Console.ReadLine());
                double scaledQuantity = quantity * scale;
                Console.WriteLine($"{scaledQuantity} {recipe.Ingredients[i]}");
            }
            Console.WriteLine("Recipe scaled successfully!");
        }

        public void ClearData(Recipe recipe)
        {
         Console.WriteLine("Data cleared successfully");
        }

        public void ResetQuantities(Recipe recipe)
        {                               
            recipe.Name = null;
            recipe.Ingredients = null;
            recipe.Steps = null;                  
            Console.WriteLine("Quantities reset successfully");
        }   
    }
}










       
using System;
using System.Collections.Generic;

namespace recipe_App
{
    public class working
    {
        // Recipe class to hold recipe details
        public class Recipe
        {
            // Properties for recipe name, ingredients, and steps
            public string Name { get; set; }
            public List<Ingredient> Ingredients { get; set; }
            public List<string> Steps { get; set; }

            // Constructor to initialize properties
            public Recipe()
            {
                Name = null;
                Ingredients = new List<Ingredient>();
                Steps = new List<string>();
            }
        }

        // Ingredient class to store name, quantity, unit, calories, and food group
        public class Ingredient
        {
            public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }
            public double Calories { get; set; }
            public string FoodGroup { get; set; }

            public Ingredient(string name, double quantity, string unit, double calories, string foodGroup)
            {
                this.Name = name;
                this.Quantity = quantity;
                this.Unit = unit;
                this.Calories = calories;
                this.FoodGroup = foodGroup;
            }

            // Override ToString for better display of Ingredient
            public override string ToString()
            {
                return $"{Quantity} {Unit} of {Name} ({Calories} calories, {FoodGroup})";
            }
        }

        // Method to display the main menu and handle user choices
        public void Menu(List<Recipe> recipes)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("\nWelcome, " + name + ", to the recipe app\n");

            // Main menu loop
            while (true)
            {
                // Display menu options
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipes");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Clear all data");
                Console.WriteLine("5. Exit\n");

                string choice = Console.ReadLine();

                // Switch case to handle user choices
                switch (choice)
                {
                    case "1":
                        Recipe recipe = new Recipe();
                        EnterRecipeDetails(recipe);
                        recipes.Add(recipe);
                        break;
                    case "2":
                        DisplayRecipes(recipes);
                        break;
                    case "3":
                        Scale(recipes);
                        break;
                    case "4":
                        ClearData(recipes);
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }

        // Method to enter recipe details
        public void EnterRecipeDetails(Recipe recipe)
        {
            Console.WriteLine("What is the name of your recipe?");
            recipe.Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How many ingredients are there?");
            int ingredientsCount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Loop to input ingredients
            for (int i = 0; i < ingredientsCount; i++)
            {
                Console.WriteLine("Enter name for ingredient {0}:", i + 1);
                string name = Console.ReadLine();

                Console.WriteLine("Enter quantity for ingredient {0}:", i + 1);
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter unit for ingredient {0}:", i + 1);
                string unit = Console.ReadLine();

                Console.WriteLine("Enter calories for ingredient {0}:", i + 1);
                double calories = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter food group for ingredient {0} (Starchy foods, Vegetables and fruits, Dry beans, peas, lentils and soya, Chicken, fish, meat and eggs, Milk and dairy products, Fats and oil, Water):", i + 1);
                string foodGroup = Console.ReadLine();

                recipe.Ingredients.Add(new Ingredient(name, quantity, unit, calories, foodGroup));
                Console.WriteLine();
            }

            Console.WriteLine("How many steps are there?");
            int stepsCount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Loop to input steps
            for (int i = 0; i < stepsCount; i++)
            {
                Console.WriteLine("Enter step {0}:", i + 1);
                recipe.Steps.Add(Console.ReadLine());
                Console.WriteLine();
            }
        }

        // Method to display all recipes in alphabetical order
        public void DisplayRecipes(List<Recipe> recipes)
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes entered yet.\n");
                return;
            }

            // Sort recipes alphabetically by name
            recipes.Sort((a, b) => a.Name.CompareTo(b.Name));

            // Loop to display each recipe
            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine("\nDish name: " + recipe.Name);
                Console.WriteLine("YOU WILL NEED THE FOLLOWING INGREDIENTS:");

                // Sort ingredients alphabetically by name
                recipe.Ingredients.Sort((a, b) => a.Name.CompareTo(b.Name));

                // Loop to display ingredients with name, quantity, and unit
                foreach (Ingredient ingredient in recipe.Ingredients)
                {
                    Console.WriteLine("- " + ingredient);
                }

                Console.WriteLine("HERE ARE THE STEPS TO FOLLOW:");

                // Loop to display steps
                foreach (var step in recipe.Steps)
                {
                    Console.WriteLine("- " + step);
                }
            }
            Console.WriteLine();
        }

        // Method to scale recipe
        public void Scale(List<Recipe> recipes)
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes entered yet.\n");
                return;
            }

            Console.WriteLine("Enter the name of the recipe you want to scale:");
            string recipeName = Console.ReadLine();
            Console.WriteLine();

            Recipe recipe = recipes.Find(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));
            if (recipe == null)
            {
                Console.WriteLine("Recipe not found.\n");
                return;
            }

            Console.WriteLine("Enter the scale factor:");
            double scale = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Scaled ingredients:");

            // Loop to scale ingredients
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                ingredient.Quantity *= scale;
                Console.WriteLine(ingredient);
            }
            Console.WriteLine("Recipe scaled successfully!\n");
        }

        // Method to clear all recipe data
        public void ClearData(List<Recipe> recipes)
        {
            recipes.Clear();
            Console.WriteLine("All data cleared successfully\n");
        }
    }
}

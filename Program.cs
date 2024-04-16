using System;

namespace recipe_App
{


    class Program
    {



        static void Main(string[] args)
        { 
            Recipe recipe = new Recipe();
            working working = new working();
            working.Menu(recipe);
            working.EnterRecipeDetails(recipe);   
        }

    }
}


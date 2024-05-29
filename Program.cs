using System;
using System.Collections.Generic;

namespace recipe_App { 
//st10263292
//Joshua Thomas
//refferances

//https://youtu.be/8FmE_-QXg3Y?si=iKJwYtzjlpXv17UH
//https://youtu.be/wxznTygnRfQ?si=msepBdxsLkkQ0cWg
//https://www.w3schools.com/cs/cs_user_input.php
//https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/
//https://github.com/Joshcybr/recipe_App.git
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generics-and-arrays
//https://www.geeksforgeeks.org/c-sharp-delegates/
    class Program
    {
        static void Main(string[] args)
        {
            working app = new working();
            List<working.Recipe> recipes = new List<working.Recipe>();
            app.Menu(recipes);
        }
    }
}
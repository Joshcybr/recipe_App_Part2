﻿using System;

namespace recipe_App
//st10263292
//Joshua Thomas
//refferances

//https://youtu.be/8FmE_-QXg3Y?si=iKJwYtzjlpXv17UH
//https://youtu.be/wxznTygnRfQ?si=msepBdxsLkkQ0cWg
//https://www.w3schools.com/cs/cs_user_input.php
//https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/
//https://github.com/Joshcybr/recipe_App.git
{


        class Program
        {
            static void Main(string[] args)
            {
                working app = new working();
                working.Recipe recipe = new working.Recipe();
                app.Menu(recipe);
            }
        }
    }

//start of file
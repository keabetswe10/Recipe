using System;
using System.Collections.Generic;

namespace Recipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Hello and welcome to recipe**************");
            Console.WriteLine();
            Console.WriteLine("Please enter the number of ingredients: ");
            int numIngredients = Convert.ToInt32(Console.ReadLine());
            
            List<Ingredient> ingredients = new List<Ingredient>();
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Please enter the name of the ingredient: ");
                string name = Console.ReadLine();
               
                Console.WriteLine($"Please enter the quantity of the {name}: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine($"Please enter the unit of the measurements for {name} (e.g., tablespoon): ");
                string unit = Console.ReadLine();
              
                ingredients.Add(new Ingredient(name, quantity, unit));
            }

            Console.WriteLine("Please enter the number of steps: ");
            int numSteps = Convert.ToInt32(Console.ReadLine());
           
            List<string> steps = new List<string>();
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Please enter the description for step {i + 1}: ");
                string stepDescription = Console.ReadLine();
                steps.Add(stepDescription);
                
            }

            Console.WriteLine("Ingredients entered:");
            foreach (var ingredient in ingredients)
                
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }
            

            Console.WriteLine("Steps entered:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"Step {i + 1}: {steps[i]}");
            }
        }
    }
    class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, int quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}

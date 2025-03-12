# Recipe
1.	Namespace and Class Definition:
•	The code is within the Recipe namespace.
•	The Program class contains the Main method, which is the entry point of the application.
2.	Main Method:
•	The Main method starts by printing a welcome message to the console.
•	It then prompts the user to enter the number of ingredients.
3.	Reading Ingredients:
•	The user inputs the number of ingredients, which is stored in the numIngredients variable.
•	A List<Ingredient> named ingredients is created to store the ingredient objects.
•	A for loop iterates numIngredients times, prompting the user to enter the name, quantity, and unit of each ingredient.
•	For each ingredient, an Ingredient object is created and added to the ingredients list.
4.	Reading Steps:
•	The user is prompted to enter the number of steps, which is stored in the numSteps variable.
•	A List<string> named steps is created to store the step descriptions.
•	A for loop iterates numSteps times, prompting the user to enter the description for each step.
•	Each step description is added to the steps list.
5.	Displaying Ingredients and Steps:
•	The code prints the list of ingredients entered by the user.
•	It iterates through the ingredients list and prints the quantity, unit, and name of each ingredient.
•	The code then prints the list of steps entered by the user.
•	It iterates through the steps list and prints each step with its corresponding number.
6.	Ingredient Class:
•	The Ingredient class is defined with three properties: Name, Quantity, and Unit.
•	It has a constructor that initializes these properties.
The code effectively collects and displays a recipe's ingredients and steps, providing a simple way to input and review a recipe.

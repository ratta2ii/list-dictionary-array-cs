// 1.) Declare a LIST
// 2.) Declare the datatype the list will contain
// 3.) Give the LIST a variable name
// 4.) Create a new instance of LIST using its constructor
// 5.) Add data. The curly brackets {} at the end are required, even if we're not adding anything to our LIST yet

------------------- CREATING AN EMPTY LIST ------------------------

List<string> groceryList = new List<string> {};

groceryList;
//{ }


------------------- ADDING things to the list ---------------------


groceryList.Add("spaghetti");

groceryList;
// { "spaghetti" }

groceryList.Add("tomatoes");

groceryList;
// { "spaghetti", "tomatoes" }


------------------- REMOVING things from the list ---------------------



groceryList.Remove("basil")

groceryList
// { "spaghetti", "CANDY!", "meatballs" }


------------------- ACCESSING things within the list ---------------------


groceryList[1]
// "tomatoes"

groceryList[3]
// "meatballs"
We can also redefine/overwrite items at specific indexes using similar notation:

groceryList[1] = "CANDY!";

groceryList;
// { "spaghetti", "CANDY!", "basil", "meatballs" }
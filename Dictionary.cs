// 1.) Declare a DICTIONARY
// 2.) Declare the type of data the dictionary will contain in angle brackets
// 3.) Give it a variable name
// 4.) Create a new Dictionary instance with its constructor: new Dictionary<string, string>()
// 5.) Add data. The curly brackets {} at the end are required. They contain the information we'd 
//     like to put in our Dictionary. This information is formatted in key-value pairs that are also 
//     in curly brackets. If we're creating an empty dictionary, we leave these empty.



------------------- Example of a DICTIONARY ----------------------

Dictionary<string, string> dictionaryName = new Dictionary<string, string>() {};
OR (another example)


------------------- CONTENT within a DICTIONARY -------------------

/*

We create a dictionary similar to the way we create a list, but after the parentheses we use curly brackets to associate 
letters with their matched words. Notice how we nest individual pairs of data within curly brackets to connect pieces of 
data. These are then nested within the curly brackets that define the contents of the entire dictionary.

 */
Dictionary<string, string> myDictionary = new Dictionary<string, string>() { {"A", "apple"}, {"B", "bear"} };

Dictionary<string, int> cupcakeOrder = new Dictionary<string, int>() { {"vanilla", 12}, {"chocolate", 24}, {"raspberry", 6}, {"caramel apple", 36} };

myDictionary
// { {"A", "apple"}, {"B", "bear"} }

myDictionary["A"]
// "apple"

myDictionary["B"]
// "bear"



------------------ ADDING CONTENT to a DICTIONARY -------------------

Dictionary<string, string> myDictionary = new Dictionary<string, string>() { {"A", "apple"}, {"B", "bear"} };

myDictionary["C"] = "cat";

myDictionary
// {{ "A", "apple" }, { "B", "bear" }, { "C", "cat" }}
//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

string message = "Apple, Banana, Coconut";
message = message.Replace("Coconut", "Strawberry");
message = message.Replace(",", " - ");
Console.WriteLine(message);

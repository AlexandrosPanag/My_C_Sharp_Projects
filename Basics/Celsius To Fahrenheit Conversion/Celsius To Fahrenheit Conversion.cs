//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

//Formulas
//F = C * 9/5 +32
//C = F - 32 / 1.8

int fahrenheit = 86;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

//Celsius to fahrenheit conversion
celsius = 30;
fahrenheit = ((int)celsius * 9 / 5 + 32);
Console.WriteLine("The temperature is " + fahrenheit + " Celsius.");
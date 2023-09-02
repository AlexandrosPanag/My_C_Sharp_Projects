//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

string firstword = "World";
string secondword = "Hello " + firstword;
Console.WriteLine(secondword);

string firstword2 = "World";
string secondword2 = $"Hello {firstword2}!";
Console.WriteLine(secondword2);
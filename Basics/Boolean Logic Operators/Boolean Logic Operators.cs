//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

//BOOLEAN OPERATOR == EQUAL TO
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

//BOOLEAN OPERATOR != INEQUALITY TO
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");

// COMPARISON OPERATORS
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

//BOOLEAN RETURN LOGIC
string pangram = "The quick brown cat jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("cat"));
Console.WriteLine(pangram.Contains("cow"));

//LOGICAL NEGATION OPERATOR
string pangram2 = "The quick brown cat jumps over the lazy dog.";
Console.WriteLine(!pangram2.Contains("cat"));
Console.WriteLine(!pangram2.Contains("cow"));
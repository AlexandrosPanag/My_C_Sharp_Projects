//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

string[] stringarray = { "Ross", "Bob", "Doe", "John", "Alex", "Smith" };

Console.WriteLine("");

Array.Clear(stringarray, 0, 2); //command to clear the first (0) and given element position (2), try switching to 3 and 6!
Console.WriteLine($"Clearing 2 ... from all the elements: {stringarray.Length}");
foreach (var i in stringarray)
{
    Console.WriteLine($"-- {i}");
}
//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

string[] stringarray = { "Ross", "Bob", "Doe", "John", "Alex", "Smith" };

Console.WriteLine("Sorted...");
Array.Sort(stringarray);
foreach (var i in stringarray)
{
    Console.WriteLine($"-- {i}");
}

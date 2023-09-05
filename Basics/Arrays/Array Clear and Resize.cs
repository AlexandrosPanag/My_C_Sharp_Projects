//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

string[] stringarray = { "Ross", "Bob", "Doe", "John", "Alex", "Smith" };

Console.WriteLine("");

Array.Clear(stringarray, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {stringarray.Length}");
foreach (var pallet in stringarray)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref stringarray, 8);
Console.WriteLine($"Resizing the size of the array to 8 ... new array count: {stringarray.Length}");

stringarray[6] = "Emily";
stringarray[7] = "Amy";

foreach (var i in stringarray)
{
    Console.WriteLine($"-- {i}");
}
//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

Random randomnum = new Random();
int randnum1 = randomnum.Next(); //this line will result in a number generated between the range from 0 to 2,147,483,647
int randnum2 = randomnum.Next(101); //this line will result in a number generated between the range of 0 to 100
int randnum3 = randomnum.Next(50, 101); //this line will result in a number generated from the range of 50 to 100

Console.WriteLine($"First roll: {randnum1}");
Console.WriteLine($"Second roll: {randnum2}");
Console.WriteLine($"Third roll: {randnum3}");
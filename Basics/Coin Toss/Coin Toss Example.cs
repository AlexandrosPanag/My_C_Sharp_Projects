//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "The coin is: Tails!" : "The coin is: Heads!");
//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

int hero = 10;
int monster = 10;
int boss = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

hero = 10;
Console.WriteLine("The hero proceeds to fight the final boss.");

do
{
    int roll = dice.Next(1, 11);
    boss -= roll;
    Console.WriteLine($"Boss was damaged and lost {roll} health and now has {monster} health.");

    if (boss <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && boss > 0);

Console.WriteLine(hero > boss ? "Hero wins!" : "Boss wins!");
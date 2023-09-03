//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int score = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {score}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +5 bonus to score!");
        score += 5;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to score!");
        score += 2;
    }
}

//if the score is above or equal to 15 you win the game
if (score >= 15)
{
    Console.WriteLine("You win!");
}
else //else you lose the game
{
    Console.WriteLine("Sorry, you lose.");
}

//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

int[] salary = { 5200 , 2000, 4500, 7000, 1750, 2500 };
int sum = 0;
int total = 0;
int average = 0;


foreach (int items in salary)
{
    total++;
    sum += items;
}
average = sum / total;

Console.WriteLine("The average salary is: " + average);
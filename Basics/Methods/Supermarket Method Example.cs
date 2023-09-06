//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

double total = 0;

double budget = 300;
double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

Console.WriteLine($"Budget:"+budget+"$");
Console.WriteLine($"Total: ${FormatDecimal(total)}");
if (budget > total) //check if the budget is bigger than the money spent
{
    Console.WriteLine($"The remaining cash will be:" + (budget - total) + "$");
}
else //the budget is less than the required amount!
{
    Console.WriteLine($"The amount of items exceeds the budget!! You owe a total of:" + (budget - total) + "$");
}
double GetDiscountedPrice(int itemIndex) //removes the price from every item according to the discount
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}


string FormatDecimal(double input) //method to return a substring (optional)
{
    return input.ToString().Substring(0, 5);
}
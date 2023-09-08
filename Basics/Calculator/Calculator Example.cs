// Alexandros Panagiotakopoulos - alexandrospanag.github.io

int result = 0;

// Read the first User Input
Console.WriteLine("Give the first number :");
int num1 = Convert.ToInt32(Console.ReadLine());


// Read the second User Input
Console.WriteLine("Give the second number :");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter symbol(/,+,-,*,%):");
string symbol = Console.ReadLine();

switch (symbol)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine("Addition:" + result);
        break;
    case "-":
        result = num1 - num2;
        Console.WriteLine("Subtraction:" + result) ;
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine("Multiplication:" + result);
        break;
    case "/":
        result = num1 / num2;
        Console.WriteLine("Division:" + result);
        break;
    case "%":
        result = num1 % num2;
        Console.WriteLine("Modulation:" + result);
        break;
    default:
        Console.WriteLine("Wrong input");
        break;
}
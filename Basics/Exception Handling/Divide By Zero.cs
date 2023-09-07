// Alexandros Panagiotakopoulos - alexandrospanag.github.io

try // try code block - code that may generate an exception
{
    Process1();
}
catch // catch code block - code to handle an exception
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exitting the program");

static void Process1()
{
    DivByZero();
}

static void DivByZero()
{
    double float1 = 100.0;
    double float2 = 0.0;
    int number1 = 100;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}

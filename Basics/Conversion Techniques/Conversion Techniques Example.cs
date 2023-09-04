//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

//convert string to int using parsing
string first = "3";
string second = "4";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

//convert string to int using convert class
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);


//converting decimal to int using casting
int value3 = (int)3.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4);

//TryParse conversion method
string value5 = "102";
int result2 = 0;
if (int.TryParse(value5, out result2))
{
    Console.WriteLine($"Measurement: {result2}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

string value = "open sesame";
char[] valueArray = value.ToCharArray(); //turn the string into a char array
Console.WriteLine(valueArray); //print the array
string result = String.Join(",", valueArray); //join each array element with a comma element
Console.WriteLine(result); //print the array

string[] items = result.Split(','); //split each element seperated by a comma
foreach (string item in items) //for each element
{
    Console.WriteLine(item); //print it
}

//This code is officially written by Microsoft and can be found here : https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/4-exercise-create-methods-return-strings
//It was a really good example that I just had to include it on my notes!
//I highly encourage you to check out the official work along with this course offered by freeCodeCamp along with Microsoft on the link bellow
//https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/

string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}
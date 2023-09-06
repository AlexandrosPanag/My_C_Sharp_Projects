//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

string message = "{What if} there are {way more than} one {set of brackets}?";
while (true)
{
    int openingPosition = message.IndexOf('{');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf('}');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}
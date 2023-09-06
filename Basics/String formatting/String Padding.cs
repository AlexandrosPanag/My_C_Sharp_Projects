//By Alexandros Panagiotakopoulos - alexandrospanag.github.io


string paymentId = "769";
string payeeName = "Mr. Oxford Orburg";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6); //Payment ID is 3 characters long, adding on space completes the padding to 6.
formattedLine += payeeName.PadRight(24); //Payment name is 17 characters long, adding on space completes the padding to 24.
formattedLine += paymentAmount.PadLeft(10); //Payment amount is 8 characters long, adding on space completes the padding to 10.

Console.WriteLine("Transaction ID: 0123456789");
Console.WriteLine(formattedLine);

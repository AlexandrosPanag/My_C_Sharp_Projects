//By Alexandros Panagiotakopoulos - alexandrospanag.github.io
// 12/09/2024

using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.WriteLine("Enter a string to convert to Grey Code:");
        string input = Console.ReadLine();

        // Convert each character in the string to its binary representation
        foreach (char c in input)
        {
            // Get the ASCII value of the character
            int asciiValue = (int)c;

            // Convert the ASCII value to binary
            string binary = Convert.ToString(asciiValue, 2).PadLeft(8, '0');

            // Convert the binary value to Grey Code
            string greyCode = BinaryToGrey(binary);

            // Print the Grey Code
            Console.WriteLine($"Character: {c}, ASCII: {asciiValue}, Binary: {binary}, Grey Code: {greyCode}");
        }
    }

    // Method to convert binary to Grey Code
    static string BinaryToGrey(string binary)
    {
        // Initialize the Grey Code with the first binary digit
        string grey = binary[0].ToString();

        // Compute the remaining Grey Code digits
        for (int i = 1; i < binary.Length; i++)
        {
            // XOR the current binary digit with the previous binary digit
            grey += (binary[i - 1] == binary[i]) ? '0' : '1';
        }

        return grey;
    }
}
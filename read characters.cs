using System;

class Program
{
    static void Main()
    {
        char inputChar;
        int inputInt;

        do
        {
            Console.WriteLine("Please enter a character (not a number):");
            string input = Console.ReadLine();

            if (input.Length == 1 && !char.IsDigit(input[0]))
            {
                inputChar = input[0];
                Console.WriteLine($"You entered: {inputChar}");
                break; 
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        } while (true); 
    }
}


using System;

class Program
{
    static void Main()
    {
        int number;
        string input;
        bool isNumber;

        do
        {
            Console.WriteLine("Please enter a number :");
            input = Console.ReadLine();

  
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

    
            isNumber = true;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c < '0' || c > '9')
                {
                    isNumber = false;
                    break;
                }
            }

            if (isNumber && int.TryParse(input, out number))
            {
                Console.WriteLine($"You entered the number: {number}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (true);
    }
}

using System;

class Program
{
    static void Main()
    {
        int n;
        char choice;

        do
        {
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            if (n == 0)
            {
                Console.WriteLine("0 is in the Fibonacci sequence.");
            }
            else
            {
                while (c < n)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }

                if (c == n)
                {
                    Console.WriteLine($"{n} is in the Fibonacci sequence.");
                }
                else
                {
                    Console.WriteLine($"{n} is not in the Fibonacci sequence.");
                }
            }

            
   

using System;

class Program
{
    static void Main()
    {
        int m, n;

        Console.Write("Enter the first number (m): ");
        m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (n): ");
        n = Convert.ToInt32(Console.ReadLine());

       
        if (m > n)
        {
            int temp = m;
            m = n;
            n = temp;
        }

        Console.WriteLine("Prime numbers between " + m + " and " + n + ":");

       
        while (m <= n)
        {
            if (IsPrime(m))
            {
                Console.WriteLine(m);
            }
            m++;
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false; 
        if (number == 2) return true; 

        int i = 2;
        while (i <= Math.Sqrt(number))
        {
            if (number % i == 0)
            {
                return false; 
            }
            i++;
        }

        return true; 
}

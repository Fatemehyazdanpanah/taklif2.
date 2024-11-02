using System;

class Program
{
    static void Main()
    {
        int m, n;

     
        Console.Write("Enter the first number (m): ");
        m = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number (n): ");
        n = int.Parse(Console.ReadLine());

       
        if (m > n)
        {
            int temp = m;
            m = n;
            n = temp;
        }

        int current = m;

       
        do
        {
            int original = current;
            int reverse = 0;

           
            while (original > 0)
            {
                reverse = reverse * 10 + (original % 10);
                original /= 10;
            }

            if (reverse >= m && reverse <= n && reverse != current)
            {
                Console.WriteLine($"Mirror-reversed number: {current} -> {reverse}");
            }

            current++;
        } while (current <= n);
    }
}

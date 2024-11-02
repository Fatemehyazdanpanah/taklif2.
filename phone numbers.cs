using System;

class Program
{
    static void Main()
    {
        string text = "Hello, my phone number is 0123456789, my address is rue Voltaire 145. " +
                      "the number 1234567890 is not valid anymore. Contact the number 0147258369 if you have any question " +
                      "the number 012345678 is not valid anymore. Contact the number 0999999888 if you have any question " +
                      "Our customer care representatives are available to assist you 24 hours a day, 7 days a week on : 0000000000, 9999999999 and 0777778899";

        int index = 0;

        while (index < text.Length)
        {
            
            if (text[index] == '0' && index + 9 < text.Length)
            {
             
                string phoneNumber = text.Substring(index, 10);

               
                if (IsValidPhoneNumber(phoneNumber))
                {
                    Console.WriteLine(phoneNumber);
                }

                index++;
            }
            else
            {
                
                index++;
            }
        }
    }

    static bool IsValidPhoneNumber(string number)
    {
        
        if (number.Length != 10) return false;

        int differentDigitsCount = 0;
        bool[] digitSeen = new bool[10]; 

        for (int i = 0; i < number.Length; i++)
        {
            int digit = number[i] - '0'; 
            if (!digitSeen[digit])
            {
                digitSeen[digit] = true;
                differentDigitsCount++; 
            }
        }

        return differentDigitsCount >= 2; 
    }
}

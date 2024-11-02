
using System;

namespace InterestDecisionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sports Interest Decision Tree!");
            bool likesFootball = AskQuestion("Do you like football? (y/n)");

            if (likesFootball)
            {
                bool playsFootball = AskQuestion("Do you play football? (y/n)");
                if (playsFootball)
                {
                    Console.WriteLine("Great! You're a football player!");
                }
                else
                {
                    Console.WriteLine("Nice! You enjoy watching football!");
                }
            }
            else
            {
                bool likesVolleyball = AskQuestion("Do you like volleyball? (y/n)");
                if (likesVolleyball)
                {
                    bool playsVolleyball = AskQuestion("Do you play volleyball? (y/n)");
                    if (playsVolleyball)
                    {
                        Console.WriteLine("Awesome! You're a volleyball player!");
                    }
                    else
                    {
                        Console.WriteLine("Cool! You enjoy watching volleyball!");
                    }
                }
                else
                {
                    Console.WriteLine("It seems you're not interested in football or volleyball.");
                }
            }

            Console.WriteLine("Thank you for participating! Press any key to exit.");
            Console.ReadKey();
        }

        static bool AskQuestion(string question)
        {
            Console.WriteLine(question);
            char answer;

            do
            {
                Console.Write("Enter (y/n): ");
                answer = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (answer != 'y' && answer != 'n');

            return answer == 'y';
        }
    }
}

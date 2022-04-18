using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(1, 11);
            
            Console.WriteLine("Try guess random number!");
            Console.WriteLine("Enter the number:");
            
            bool loopActive = true;
            while (loopActive)
            {
                int k = Convert.ToInt32(Console.ReadLine());

                if (k == i)
                {
                    Console.WriteLine($"Yes!You WIN! Random number is " + k + "!");
                    loopActive = false;
                }
                else 
                {
                    Console.WriteLine("You did not guess right, try again !");
                    
                }
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}

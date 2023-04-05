using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNum= random.Next(1, 10);
            int guess;

            Console.WriteLine("I am thinking of a number between 1-10.  Will you be able to guess what it is?");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess != randomNum) 
            {
                Console.WriteLine("Wrong! The number was " + randomNum);
                Console.ReadKey();
            }
            else if (guess == randomNum) 
            {
                Console.WriteLine("Correct! Good job");
                Console.ReadKey();
            }


        }
    }
}

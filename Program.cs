using System;

namespace SnakeNLadder
{
    class Program
    {
        const int startPoint =0;
        public static void Main(string[]args)
        {
            Random random = new Random();
            int diceThrow = random.Next(1, 7);

            Console.WriteLine("Die roll for player1  " + diceThrow);
            Console.ReadLine();
        }
        
    }
}

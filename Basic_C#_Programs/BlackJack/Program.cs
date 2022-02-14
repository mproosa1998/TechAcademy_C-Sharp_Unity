using System;
using System.IO;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to blackjack. What is your Name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to play a game?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new BlackjackGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around. Bye for now.");

            Console.ReadLine();
        }
    }
}

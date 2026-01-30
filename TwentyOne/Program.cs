using System;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new player object
            Player player = new Player()
            {
                Name = "Player One",
                Balance = 100,
                Stay = false
            };

            // Create a dealer object
            Dealer dealer = new Dealer();

            // Main game loop
            while (!player.Stay && player.Balance > 0)
            {
                // Call the Play method to run one round of the game
                TwentyOneRules.Play(player, dealer);

                // Ask the player if they want to continue
                Console.WriteLine("Do you want to stay? (y/n)");
                string input = Console.ReadLine();

                // Set Stay to true if player chooses yes
                if (input.ToLower() == "y")
                {
                    player.Stay = true;
                }
            }

            Console.WriteLine("Game over.");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOne
{
    // Contains game rules for Twenty-One
    class TwentyOneRules
    {
        // Play one round of the game
        public static void Play(Player player, Dealer dealer)
        {
            // Add a card to the player's hand
            player.Hand.Add(new Card { Face = "Ten", Value = 10 });

            // Calculate total hand value
            int total = player.Hand.Sum(card => card.Value);

            // Display the player's total
            Console.WriteLine("Player total: " + total);

            // Deduct money if total exceeds 21
            if (total > 21)
            {
                Console.WriteLine("Bust! You lose $10.");
                player.Balance -= 10;
                player.Stay = true;
            }
        }
    }
}

using System;                 // Provides access to Console
using System.Collections.Generic; // Provides access to List<T>

namespace TwentyOne
{
    // This is the base Game class that other games can inherit from
    public class Game
    {
        // List that stores all players participating in the game
        public List<Player> Players { get; set; }

        // Property that represents the dealer of the game
        public Dealer Dealer { get; set; }

        // Constructor initializes the Players list
        public Game()
        {
            Players = new List<Player>(); // Creates an empty list of players
        }

        // Virtual method that starts the game
        // Virtual allows child classes to override this behavior
        public virtual void Play()
        {
            // Inform the user that the game has started
            Console.WriteLine("The game has started.");
        }

        // Virtual method that ends the game
        public virtual void EndGame()
        {
            // Inform the user that the game has ended
            Console.WriteLine("The game has ended.");
        }
    }
}

using System.Collections.Generic;

namespace TwentyOne
{
    // Represents a player in the game
    class Player
    {
        public string Name { get; set; }          // Player name
        public int Balance { get; set; }          // Player balance
        public bool Stay { get; set; }             // Whether the player stays
        public List<Card> Hand { get; set; } = new List<Card>(); // Player cards
    }
}

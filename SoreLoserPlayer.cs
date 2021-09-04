namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            // call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{Name} is waiting for others!");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll) 
            {
                Console.WriteLine($"{Name} wins!");
            }
            else if (myRoll < otherRoll)
            {
                try 
                {
                    Console.WriteLine($"{other.Name} wins!");
                    Console.WriteLine($"{Name} says the other player: {other.Name} is a cheater!")
                }
                catch
                {
                    Console.WriteLine($"{Name} says the other player: {other.Name} is cheating!");
                }
                else 
                {
                    // if it's a tie
                    Console.WriteLine($"It is a tie!");
                }
            }
            
        }
    }
}
namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer
    {
        public override void Play(Player other)
        {
            // call roll for "this" object and for the "other" object
            int myRoll = other.Roll + 1; // this ensures that this type of player will always roll one higher than the other player
            int otherRoll = other.ROll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            Console.WriteLine($"{Name} rolls one higher than the other player!");

            if (myRoll > otherRoll) 
            {
                Console.WriteLine($"{Name} wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} wins!");
            }
            else 
            {
                // if the rolls are equal it is a tie
                Console.WriteLine("It is a tie");
            }
        }
    }
}

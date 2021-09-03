namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }

        public override void Play(Player other)
        // call roll for "this" object and for the "other" object

        int myRoll();
        int otherRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll}!");
        Console.WriteLine($"{Name} taunts other Players: Prepare to meet your maker!");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");

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
            // if the rolls are equal it's a tie
            Console.WriteLine("Its a tie!");
        }
    }
}
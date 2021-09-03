namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // return a ranom number between 1 and the DiceSize that is always in the upper half of the possible rolls :
            // default value of DiceSize is 6, so dividing variable by 2 and passing halfed result as a parameter and the initial value
            // of DiceSize as a second parameter to the Next() methos ensures the rolls will always be between 4 and 6:
            return new Random().Next((DiceSize/2), DiceSize) + 1;
        }

        public override void Play(Player other)
        {
            // call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int myOtherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}.");
            Console.WriteLine($"{Name} always rolls in the upper half, nice!");
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
                // if the rolls are equal
                Console.WriteLine("It's a tie");
            }
        }
    }
}
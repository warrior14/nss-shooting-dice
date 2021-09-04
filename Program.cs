using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($@"
            Let's play a game of shooting dice!");
          // instantiating new SmackTalkingPlayer subclass to create object that inherits attributes of the Player base class:
            Player player1 = new SmackTalkingPlayer();
            player1.Name = "Luke";

            // instantiating new OneHigherPlayer subclass to create object that inherits attributes of the Player base class:
            Player player2 = new OneHigherPlayer();
            player2.Name = "Gabe";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            // instantiating new HumanPlayer subclass to create object that inherits attributes of the Player base class:
            Player player3 = new HumanPlayer();
            player3.Name = "Luz (Human Player)";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Harry Potter";

            player1.Play(large);

            Console.WriteLine("-------------------");

            // instantiating new SmackTalkingPlayer subclass to create object that inherits attributes of the Player base class:
            Player smackTalker = new SmackTalkingPlayer { Name = "Tom Holland"};

            smackTalker.Play(player3);

            Console.WriteLine("-------------------");

            // instantiating new OneHigherPlayer subclass to create object that inherits attributes of the Player base class:
            Player higherPlayer = new OneHigherPlayer { Name = "Brad Pitt"};

            higherPlayer.Play(player2);

            Console.WriteLine("-------------------");

            // instantiating new CreativeSmackTalkingPlayer subclass to create object that inherits attributes of the Player base class:
            Player creativeSmackTalker = new CreativeSmackTalkingPlayer { Name = "Hercules"};

            creativeSmackTalker.Play(large);

            Console.WriteLine("-------------------");

            // instantiating new SoreLoserPlayer subclass to create object that inherits attributes of the Player base class:
            Player soreLoser = new SoreLoserPlayer { Name = "Obama"};

            soreLoser.Play(creativeSmackTalker);

            Console.WriteLine("-------------------");

            // instantiating new UpperHalfPlayer subclass to create object that inherits attributes of the Player base class:
            Player upperHalf = new UpperHalfPlayer { Name = "Henry Calvin"};

            upperHalf.Play(soreLoser);

            Console.WriteLine("-------------------");

            // instantiating new SoreLoserUpperHalfPlayer subclass to create object that inherits attributes of the Player base class:
            Player upperHalfSoreLoser = new SoreLoserUpperHalfPlayer { Name = "James Bond"};

            upperHalfSoreLoser.Play(upperHalf);


            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smacktalker, higherPlayer, creativeSmackTalker, soreLoser, upperHalf, upperHalfLoser
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?!");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}
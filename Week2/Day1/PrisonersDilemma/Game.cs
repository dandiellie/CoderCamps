using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    public class Game
    {
        public int Rounds { get; set; }
        public Random Rand { get; set; }
        public int Player1LastChoice { get; set; }
        public int Player2LastChoice { get; set; }

        public Game()
        {
            Rand = new Random();
            Rounds = 1;
            Player1LastChoice = 0;
            Player2LastChoice = 0;
        }
        
        public Game(int numRounds)
        {
            Rand = new Random();
            Rounds = numRounds;
            Player1LastChoice = 0;
            Player2LastChoice = 0;
        }

        public void CompareStrategies(IPlayer p1, IPlayer p2)
        {
            p1.ChoosePlay(Rand, Player1LastChoice);
            p2.ChoosePlay(Rand, Player2LastChoice);

            Player1LastChoice = p1.Play;
            Player2LastChoice = p2.Play;

            switch(p1.Play)
            {
                case 1:
                    switch(p2.Play)
                    {
                        case 1:                 //Player 1 cooperates, Player 2 cooperates
                            p1.Years += 1;
                            p2.Years += 1;
                            break;
                        case 2:                 //Player 1 cooperates, Player 2 defects
                            p1.Years += 3;
                            break;
                        default:
                            throw new Exception("Players didn't make valid choices!");
                    }
                    break;
                case 2:
                    switch (p2.Play)
                    {
                        case 1:                 //Player 1 defects, Player 2 cooperates
                            p2.Years += 3;
                            break;
                        case 2:                 //Player 1 defects, Player 2 defects
                            p1.Years += 2;
                            p2.Years += 2;
                            break;
                        default:
                            throw new Exception("Players didn't make valid choices!");
                    }
                    break;
                default:
                    throw new Exception("Players didn't make valid choices!");
            }
        }

        public void RunGame(IPlayer p1, IPlayer p2)
        {
            p1.Years = 0;
            p2.Years = 0;
            
            for (int i = 0; i < Rounds; i++)
            {
                CompareStrategies(p1, p2);
            }

            if(p1.Years < p2.Years)
            {
                Console.WriteLine(string.Format("Player 1 won with {0} years to Player 2's {1} years.\n", p1.Years, p2.Years));
            }
            else if (p2.Years < p1.Years)
            {
                Console.WriteLine(string.Format("Player 2 won with {0} years to Player 1's {1} years.\n", p2.Years, p1.Years));
            }
            else
            {
                Console.WriteLine(string.Format("The players tied with {0} years.\n", p1.Years));
            }
        }
    }
}

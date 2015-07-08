using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRand = new Random();
            int length = 100; //sets the number of times the game will be played before declaring a winner
            
            Player Player1 = new Player();
            Player Player2 = new Player();

            for (int i = 0; i < length; i++)
            {
                Player1.Act(myRand);
                Player2.Act(myRand);
                Game.Fight(Player1, Player2);
            }

            string winner = "";
            if (Player1.Score > Player2.Score)
            {
                winner = "Player 1 is the Champion!!";
            }
            else if (Player1.Score < Player2.Score)
            {
                winner = "Player 2 is the Champion!!";
            }
            else
            {
                winner = "You're both Champions!!";
            }

            Console.WriteLine(string.Format("\nWe have a winner!! {0}", winner));
            Console.WriteLine(string.Format("Player 1: {0}, Player 2: {1}", Player1.Score, Player2.Score));

            //pause
            Console.ReadLine();
        }
    }

    enum PlayerMove
    {
        Rock, Paper, Scissors
    }
    
    class Player
    {
        public PlayerMove Move { get; set; }
        public int Score { get; set; }

        public void Act(Random r)
        {
            int n = r.Next(3);
            switch (n)
            {
                case 0:
                    Move = PlayerMove.Rock;
                    break;
                case 1:
                    Move = PlayerMove.Paper;
                    break;
                default:
                    Move = PlayerMove.Scissors;
                    break;
            }
        }
    }

    class Game
    {
        public static void Fight(Player p1, Player p2)
        {
            switch (p1.Move)
            {
                case PlayerMove.Rock:
                    switch (p2.Move)
                    {                       
                        case PlayerMove.Rock:                       //tie
                            p1.Score += 1;
                            p2.Score += 1;
                            Console.WriteLine("Tie! You both got Rock!");
                            break;
                        case PlayerMove.Paper:                      //Player 2
                            p1.Score -= 2;
                            p2.Score += 2;
                            Console.WriteLine("Player 2 wins with Paper over Rock!");
                            break;
                        default:                                    //Player 1
                            p1.Score += 2;
                            p2.Score -= 2;
                            Console.WriteLine("Player 1 wins with Rock over Scissors!");
                            break;
                    }
                    break;
                case PlayerMove.Paper:
                    switch (p2.Move)
                    {
                        case PlayerMove.Rock:                       //Player 1
                            p1.Score += 2;
                            p2.Score -= 2;
                            Console.WriteLine("Player 1 wins with Paper over Rock!");
                            break;
                        case PlayerMove.Paper:                      //tie
                            p1.Score += 1;
                            p2.Score += 1;
                            Console.WriteLine("Tie! You both got Paper!");
                            break;
                        default:                                    //Player 2
                            p1.Score -= 2;
                            p2.Score += 2;
                            Console.WriteLine("Player 2 wins with Scissors over Paper!");
                            break;
                    }
                    break;
                default:
                    switch (p2.Move)
                    {
                        case PlayerMove.Rock:                       //Player 2
                            p1.Score -= 2;
                            p2.Score += 2;
                            Console.WriteLine("Player 2 wins with Rock over Scissors!");
                            break;
                        case PlayerMove.Paper:                      //Player 1
                            p1.Score += 2;
                            p2.Score -= 2;
                            Console.WriteLine("Player 1 wins with Scissors over Paper!");
                            break;
                        default:                                    //tie
                            p1.Score += 1;
                            p2.Score += 1;
                            Console.WriteLine("Tie! You both got Scissors!");
                            break;
                    }
                    break;
            }
        }
    }
}

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

        public Game()
        {

        }
        
        public Game(int r)
        {
            Rounds = r;
        }

        public void CompareStrategies(Player p1, Player p2)
        {
            p1.ChoosePlay();
            p2.ChoosePlay();

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
    }
}

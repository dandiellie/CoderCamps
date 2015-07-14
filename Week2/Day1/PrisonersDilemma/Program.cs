using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(1000); //Set up to play # rounds.
            var player1 = new UnTitForTat();
            var player2 = new UnTitForTat();

            myGame.RunGame(player1, player2);

            Console.ReadLine(); //pause
        }
    }
}

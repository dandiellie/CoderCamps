using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissors.Models
{
    public enum PlayerMove
    {
        Rock, Paper, Scissors
    }
    
    public class Player
    {
        public PlayerMove Move { get; set; }
        public int Score { get; set; }
    }
}
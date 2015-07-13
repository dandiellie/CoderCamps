using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    public class Cooperator: Player
    {
        public override void ChoosePlay()
        {
            Play = 1;
        }
    }
}

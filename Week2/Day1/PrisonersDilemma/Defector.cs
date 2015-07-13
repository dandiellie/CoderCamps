using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    public class Defector: Player
    {
        public void ChoosePlay()
        {
            Play = 2;
        }
    }
}

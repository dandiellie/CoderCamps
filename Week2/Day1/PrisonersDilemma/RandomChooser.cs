using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    class RandomChooser: Player
    {
        public void ChoosePlay(Random r)
        {
            Play = r.Next(2) + 1;
        }
    }
}

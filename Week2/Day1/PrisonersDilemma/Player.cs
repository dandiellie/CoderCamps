using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    public abstract class Player
    {
        public int Years { get; set; }
        public int Play { get; set; }

        public Player()
        {
            Years = 0;
            Play = 0;
        }

        public void ChoosePlay()
        {

        }
    }
}

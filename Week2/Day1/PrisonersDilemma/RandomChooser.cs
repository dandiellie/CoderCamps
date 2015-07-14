using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    class RandomChooser: IPlayer
    {
        public int Years { get; set; }
        public int Play { get; set; }

        public RandomChooser()
        {
            Years = 0;
            Play = 0;
        }
        
        public void ChoosePlay(Random r, int p)
        {
            Play = r.Next(2) + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    public class UnTitForTat: IPlayer
    {
        public int Years { get; set; }
        public int Play { get; set; }

        public UnTitForTat()
        {
            Years = 0;
            Play = 0;
        }
        
        public void ChoosePlay(Random r, int p)
        {
            if (p == 0)
            {
                Play = r.Next(2) + 1;
            }
            else if (p == 1)
            {
                Play = 2;
            }
            else
            {
                Play = 1;
            }
        }
    }
}

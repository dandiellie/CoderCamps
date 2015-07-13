using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    public class UnTitForTat: Player
    {
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

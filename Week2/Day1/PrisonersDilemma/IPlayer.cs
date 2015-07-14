using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonersDilemma
{
    public interface IPlayer
    {
        int Years { get; set; }
        int Play { get; set; }

        void ChoosePlay(Random r, int p);
    }
}

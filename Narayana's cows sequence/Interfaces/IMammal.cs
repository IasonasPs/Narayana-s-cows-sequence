using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narayana_s_cows_sequence.Interfaces
{
    internal interface IMammal
    {
        public int Age { get; set; }

        public bool AbleToReproduce(int year);

    }
}

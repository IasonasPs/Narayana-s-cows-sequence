using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Narayana_s_cows_sequence.Interfaces;

namespace Narayana_s_cows_sequence.Models
{
    internal class Cow : IMammal
    {
        public readonly int yearOfBirth;
        int IMammal.Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age
        {
            get
            {
                return 0;
            }

            set { }
        }

        public bool AbleToReproduce(int year)
        {
            if (year - yearOfBirth >= 3)
            {
                return true;
            }
            return false;
        }



        public Cow(int year)
        {
            yearOfBirth = year;
        }
    }
}

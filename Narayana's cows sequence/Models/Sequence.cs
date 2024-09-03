using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Narayana_s_cows_sequence.Helpers;

namespace Narayana_s_cows_sequence.Models
{
    internal class Sequence
    {
        public static void GetSequence(int maxYear)
        {
            int year = 0;
            Cow cow0 = new Cow(year);
            List<Cow> population = new(200)
            { cow0 };

            while (year < maxYear)
            {
                for (int i = 0; i < population.Count; i++)
                {
                    if (population[i].AbleToReproduce(year))
                    {
                        population.Add(new Cow(year));
                    }
                }

                var l = Convert.ToInt64(population.Count);
                Console.WriteLine("Year : {1} , Population : {0}", EuropeanΝumberFormat.ChangeFormat(l), year);
                year++;
            }
            Console.ReadLine();
        }
    }
}

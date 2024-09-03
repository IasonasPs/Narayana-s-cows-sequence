using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narayana_sCowsVersion2
{
    internal class Sequence
    {

        public static List<int> population = new List<int>(100000000)
        {
            4
        };
        
        public static void Begin(int maxYear)
        {
            int year = 0;
            while (year < maxYear)
            {
                for (int i = 0; i < population.Count; i++)
                {
                    if (population[i] >= 4)
                    {
                        population.Add(1);
                    }
                    else
                    {
                        population[i]++;
                    }
                }
                Console.WriteLine("{0}---->       {1}",year,population.Count);
                year++;
            }
        }
    }
}

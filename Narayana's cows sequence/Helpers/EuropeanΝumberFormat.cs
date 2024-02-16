using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narayana_s_cows_sequence.Helpers
{
    internal static class EuropeanΝumberFormat
    {
        public static string ChangeFormat(long number)
        {
            List<long> result = GetRemainder(number);
            StringBuilder sb = new StringBuilder();
            foreach (var item in result)
            {
                sb.Append(item.ToString());
                if (result.Last() != item)
                {
                    sb.Append('.');
                }
            }
            return sb.ToString();
        }
        public static List<long> GetRemainder(long num)
        {
            //long length = num % 1000000 > 100 ? 4 : 8; 
            //long[] longs = new long[length];
            List<long> longs = new List<long>();

            while (num > 1000)
            {
                longs.Add(num % 1000);
                num = num / 1000;
            }
            longs.Add(num);
            longs.Reverse();
            return longs;
        }
    }
}

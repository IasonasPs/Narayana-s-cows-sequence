namespace Narayana_sCowsVersion3
{
    internal static class Sequence
    {
        public static void Begin(int maxYear)
        {
            long[] cows =
            [
                1,  //adults [0]
                0,  //3yo    [1]   
                0,  //2yo    [2]
                0,  //1yo    [3]
            ];

            int year = 0;
            while (year < maxYear)
            {
                cows[0] += cows[1];
                cows[1] = cows[2];
                cows[2] = cows[3];
                cows[3] = cows[0];
                Console.WriteLine("Year : {1}---->     {0}",
                    cows[0] + cows[1] + cows[2] + cows[3], year);

                year++;
            }
        }

        public static void BeginHexadecimal(int maxYear) 
        {
            long[] cows =
            {
                0x1,
                0x0,
                0x0,
                0x0
            };

            int year = 0;
            while (year < maxYear)
            {
                cows[0] += cows[1];
                cows[1] = cows[2];
                cows[2] = cows[3];
                cows[3] = cows[0];
                Console.WriteLine($"Year : {year} ----> {cows[0] + cows[1] + cows[2] + cows[3]:X}");
                year++;
            }
        }

        public static void BeginBinary(int maxYear)
        {
            long[] cows =
            {
                0b1,
                0b0,
                0b0,
                0b0
            };

            int year = 0;
            while (year < maxYear)
            {
                cows[0] += cows[1];
                cows[1] = cows[2];
                cows[2] = cows[3];
                cows[3] = cows[0];
                Console.WriteLine($"Year : {year} ----> {cows[0] + cows[1] + cows[2] + cows[3]:B}");
                year++;
            }
        }
    }
}
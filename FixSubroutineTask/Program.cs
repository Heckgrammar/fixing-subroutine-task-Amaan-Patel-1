using System;

namespace FixSubroutineTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 8; i >= 0; i--)
            {
                Console.WriteLine(diffCurrencies(i));
            }
        }

        static string diffCurrencies(int x)
        {
            string[] currencies = { "baht", "dollar", "euro", "koruna", "lira", "rand", "rupee", "yen" };

            // Check if x is within the bounds of the currencies array
            if (x >= 0 && x < currencies.Length)
            {
                return currencies[x];
            }
            else
            {
                return "Invalid currency index"; // Handle out-of-bounds index
            }
        }
    }
}

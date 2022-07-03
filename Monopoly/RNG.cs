using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    // A  Singleton Random Number Generator class 
    public class RNG
    {
        // Random number generator
        private Random rand;
        private static RNG instance = new RNG();
        private RNG() //Private constructor
        {
            rand = new Random();
        }
        public static RNG getRNG()
        {
            return instance;
        }
        public int nextInt(int minValue = 0, int maxValue = System.Int32.MaxValue)
        {
            return rand.Next(minValue, maxValue);
        }
        public double nextDouble()
        {
            return rand.NextDouble();
        }
        public int DiceRoll()
        {
            return nextInt(1, 7);
        }
    }
}

using System;

namespace RandomNumberUtility
{
    public static class Generator
    {
        private static readonly Random Rand;

        static Generator()
        {
            Rand = new Random();
        }

        /// <summary>
        /// Gets a random number within the specified range, inclusive.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetRandomNumber(int min, int max)
        {
            // Random.next's return value is not max inclusive. Offset is applied to simplify
            // the calls to this method.
            int offset = 1;

            return Rand.Next(min, max + offset);
        }
    }
}
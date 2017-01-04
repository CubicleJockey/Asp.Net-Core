using System;

namespace Services
{
    public class Primary
    {
        /// <summary>
        /// Check if an 32-bit integer is a prime number.
        /// </summary>
        /// <param name="candidate">Number to check.</param>
        /// <returns>TRUE if Prime Number, else FALSE</returns>
        public bool IsPrime(int candidate)
        {
           return IsPrime((long)candidate);
        }

        /// <summary>
        /// Check if an 64-bit integer is a prime number.
        /// </summary>
        /// <param name="candidate">Number to check.</param>
        /// <returns>TRUE if Prime Number, else FALSE</returns>
        public bool IsPrime(long candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please creat a test first.");
        }
    }
}

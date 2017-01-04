namespace Utilities
{
    public static class Maths
    {
        /// <summary>
        /// Take two numbers and add them together
        /// </summary>
        /// <param name="lhs">Left hand number.</param>
        /// <param name="rhs">Right hand numner.</param>
        /// <returns>Sum of adding two numbers.</returns>
        public static long Add(long lhs, long rhs)
        {
            return lhs + rhs;
        }

        /// <summary>
        /// Takes two numbers and subtracts them.
        /// </summary>
        /// <param name="lhs">Left hand number.</param>
        /// <param name="rhs">Right hand number.</param>
        /// <returns>Difference of adding two numbers.</returns>
        public static long Subtract(long lhs, long rhs)
        {
            return lhs - rhs;
        }

        /// <summary>
        /// Takes two numbers and Multiplies them together.
        /// </summary>
        /// <param name="lhs">Left hand number.</param>
        /// <param name="rhs">Right hand number.</param>
        /// <returns>Product of multiplying the two numbers.</returns>
        public static long Multiple(long lhs, long rhs)
        {
            return lhs * rhs;
        }

        /// <summary>
        /// Takes two numbers and divides them.
        /// </summary>
        /// <param name="dividend">Dividend</param>
        /// <param name="divisor">Divisor</param>
        /// <returns></returns>
        public static long Divide(long dividend, long divisor)
        {
            return dividend/divisor;
        }
    }
}
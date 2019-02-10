using System;
using System.Security.Cryptography;

namespace DiceTower.RNG
{
    public interface IRandomNumberGenerator 
    {
        int GenerateRandomInt(int min, int max);
    }

    /// <summary>
    /// Cryptographically-Secure Random Number Generator
    /// </summary>
    public class CSRandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly RNGCryptoServiceProvider cspRNG = new RNGCryptoServiceProvider();

        /// <summary>
        /// Generate a cryptographically-secure random integer within an inclusive range.
        /// </summary>
        /// <param name="min">Minimum range. Defaults to zero.</param>
        /// <param name="max">Maximum range. Default to int.MaxValue</param>
        /// <returns></returns>
        public int GenerateRandomInt(int min = 0, int max = int.MaxValue)
        {
            if (min > max || min == max)
            {
                throw new ArgumentOutOfRangeException($"{nameof(max)} must be larger than {nameof(min)}.");
            }

            var byteArray = new byte[4];
            cspRNG.GetBytes(byteArray);
            //convert 4 bytes to a int
            var value = BitConverter.ToInt32(byteArray, 0);
            return new Random(value).Next(min, max);
        }
    }
}

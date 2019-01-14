using System;
using System.Security.Cryptography;

namespace DiceTower.RNG
{
    public interface IRandomNumberGenerator 
    {
        int GenerateRandomInt(int min, int max);
    }
}
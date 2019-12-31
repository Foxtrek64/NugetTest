using System;

namespace NugetTest
{
    public class MathLibrary
    {
        public int Add(int left, int right)
            => left + right;

        public int Subtract(int left, int right)
            => left - right;

        public int Multiply(int left, int right)
            => left * right;

        public int Divide(int numerator, int denominator)
            => numerator / denominator;
    }
}

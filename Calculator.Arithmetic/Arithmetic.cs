using System;
namespace Calculator.Arithmetic
{
    public class Arithmetic : IArithmetic
    {
        public int Add(params int[] args)
        {
            var result = 0;
            foreach (var i in args)
                result += i;
            return result;
        }

        public int Multiply(params int[] args)
        {
            var result = 0;
            foreach (var i in args)
                result *= i;
            return result;
        }

        public int Divide(params int[] args)
        {
            var result = 0;
            foreach (var i in args)
                result /= i;
            return result;
        }

        public int Subtract(params int[] args)
        {
            var result = 0;
            foreach (var i in args)
                result -= i;
            return result;
        }
    }
}

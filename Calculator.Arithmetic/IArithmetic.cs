using System;

namespace Calculator.Arithmetic
{
    public interface IArithmetic
    {
        int Add(params int[] args);
        int Subtract(params int[] args);
        int Multiply(params int[] args);
        int Divide(params int[] args);
    }
}

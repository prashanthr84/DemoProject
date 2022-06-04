using System;

namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.Add(2, 3, 4);

            var result2 = calculator.Subtract(3, 2);
        }
    }

    internal class Calculator
    {
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int num1, int num2)
        {
            return num2 - num1;
        }
    }
}

using System;

namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.Add(2, 3);
        }
    }

    internal class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

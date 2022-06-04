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
        public object Add(int i, int i1)
        {
            return i + i1;
        }
    }
}

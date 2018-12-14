using System;

namespace Sample3
{
    public class DesignPatternSample
    {
        public void Execute()
        {
            var calculate = new AntiPatternCalculator();
            calculate.SetValue(1, 2);
            calculate.Calculate();
            Console.WriteLine(calculate.GetResult());
        }
    }
}
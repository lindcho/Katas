using System;

namespace SumKata
{
    public class SumCalculator
    {
        public string Sum(string num1, string num2)
        {
            var realNum1 = SetZeroWhenNumberIsNullOrEmpty(num1);
            var realNum2 = SetZeroWhenNumberIsNullOrEmpty(num2);

            return Convert.ToString(Add(realNum1, realNum2));
        }

        private string SetZeroWhenNumberIsNullOrEmpty(string number)
        {
            return string.IsNullOrEmpty(number) ? "0" : number;
        } 

        private int Add(string realNum1, string realNum2)
        {
            return int.Parse(realNum1) + int.Parse(realNum2);
        }
    }
}

using System;
using System.Collections.Generic;

namespace PersonalFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> PersonalFinance = new List<int> { 500, 1000, 1250, 175, 800, 120 };
            FinanceInfo(PersonalFinance);

        }
        static string FinanceInfo(List<int> input)
        {
            int a = input.Count;
            int sum, greatest, cheapest;
            sum = 0;
            input.Sort();
            cheapest = greatest = input[0];
            foreach (int i in input)
            {
                sum += i;
                if (i > greatest)
                {
                    greatest = i;
                }
                if (i < cheapest)
                {
                    cheapest = i;
                }
            }
            return $"cheapest =  {cheapest}\nGreatest = {greatest}\nsum = {sum}\naverage = {sum / input.Count}";

        }
    }
}

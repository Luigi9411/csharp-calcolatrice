using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int SumOfTwoIntegers(int num1, int num2) => num1 + num2;
        public static double SumOfTwoDoubleNumbers(double num3, double num4) => num3 + num4;
        public static int DifferenceBetweenTwoIntegers(int num1, int num2) => num1 / num2;
        public static double DifferenceBetweenTwoDoubleNumbers(double num3, double num4) => num3 / num4;
        public static int MultiplicationOfTwoIntegers(int num1, int num2) => num1 * num2;
        public static double MultiplicationOfTwoDoubleNumbers(double num3, double num4) => num3 * num4;
        public static int AbsoluteValueOfAnInteger(int num1)
        {
            {
                if (num1 < 0)
                {
                    return -num1;
                }
                else
                {
                    return num1;
                }
            }
        }

        public static double AbsoluteValueOfADoubleNumber(double num3)
        {
            {
                if (num3 < 0)
                {
                    return -num3;
                }
                else
                {
                    return num3;
                }
            }
        }

        public static int LeastOfTwoIntegers(int num1, int num2)
        {
            {
                if (num1 < num2)
                {
                    return num1;
                }
                else if (num2 < num1)
                {
                    return num2;
                }
                else num1 = num2;
                {
                    return num1;
                }
            }
        }

        public static double LeastOfTwoIntegers(double num3, double num4)
        {
            {
                if (num3 < num4)
                {
                    return num3;
                }
                else if (num4 < num3)
                {
                    return num4;
                }
                else num3 = num4;
                {
                    return num3;
                }
            }
        }

        public static int MaximumOfTwoIntegers(int num1, int num2)
        {
            {
                if (num1 < num2)
                {
                    return num2;
                }
                else
                {
                    return num1;
                }
            }
        }

        public static double MaximumOfTwoDoubleNumbers(double num3, double num4)
        {
            {
                if (num3 < num4)
                {
                    return num4;
                }
                else
                {
                    return num3;
                }
            }
        }
    }
}

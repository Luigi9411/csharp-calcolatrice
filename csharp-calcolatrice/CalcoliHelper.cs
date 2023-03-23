using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int Sum(int num1, int num2) => num1 + num2;
        public static double Sum(double num3, double num4) => num3 + num4;
        public static int Difference(int num1, int num2) => num1 - num2;
        public static double Difference(double num3, double num4) => num3 - num4;
        public static int Multiplication(int num1, int num2) => num1 * num2;
        public static double Multiplication(double num3, double num4) => num3 * num4;
        public static int AbsoluteValue(int num1)
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

        public static double AbsoluteValue(double num3)
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

        public static int Least(int num1, int num2)
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

        public static double Least(double num3, double num4)
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

        public static int Maximum(int num1, int num2)
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

        public static double Maximum(double num3, double num4)
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

        public static int GetExponentiationFunction(int num1, int num2)
        {
            if (num2 == 0 && num1 == 0)
            {
                return 1;
            }
            int result = 1;
            for (int i = 0; i < AbsoluteValue(num2); i++)
            {
                result *= num1;
            }
            if (num2 < 0)
            {
                result = 1 / result;
            }
            return result;
        }
    }
}

using System;

namespace Calculations
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumOne(int n)
        {
            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += 1 / (double)i;
            }

            return result;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumTwo(int n)
        {
            double result = 0;

            for (double i = 1; i <= n; i++)
            {
                double a = MyPow(-1D, i + 1D);
                result += a / (i * ((double)i + 1));
            }

            return result;
        }

        public static double MyPow(double number, double pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }

            return result;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumThree(int n)
        {
            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += 1 / MyPow(i, 5);
            }

            return result;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFour(int n)
        {
            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += 1 / (((2 * (double)i) + 1) * ((2 * (double)i) + 1));
            }

            return result;
        }

        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetProductOne(int n)
        {
            double result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= 1 + (1 / ((double)i * i));
            }

            return result;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFive(int n)
        {
            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += MyPow(-1, i) / ((double)(2 * i) + 1);
            }

            return result;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1!/1 + 2!/(1+1/2) + 3!/(1+1/2+1/3) + ... + n!/ (1+1/2+1/3+...+1/n), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSix(int n)
        {
            double result = 0;

            for (double i = 1; i <= n; i++)
            {
                double a = 0;

                for (double j = 1; j <= i; j++)
                {
                    a += 1 / j;
                }

                result += Fact(i) / a;
            }

            return result;
        }

        public static double Fact(double n)
        {
            double result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Calculate the following sum
        /// Sqrt(2 + Sqrt(2 + ... + Sqrt(2))), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSeven(int n)
        {
            double result = Math.Sqrt(2);

            for (int i = 1; i < n; i++)
            {
                result = Math.Sqrt(result + 2);
            }

            return result;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/sin(1) + 1/(sin(1)+sin(2)) + ...+  1/(sin(1)+sin(2)+...+sin(n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumEight(int n)
        {
            double result = default;

            for (int i = 1; i <= n; i++)
            {
                double a = default;

                for (int j = 1; j <= i; j++)
                {
                    a += Math.Sin(j * (Math.PI / 180));
                }

                result += 1 / a;
            }

            return result;
        }
    }
}

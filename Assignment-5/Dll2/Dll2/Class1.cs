using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dll2
{
    public class Class1
    {
        public static string determine(string str1, string str2)
        {
            int value = calculate(str1, str2);
            decimal counter = 1 - (decimal)value / Math.Max(str1.Length, str2.Length);
            decimal number = Math.Round(counter, 2) * 100;
            string message = "Percentage Similarity between the strings " + str1 + " and " + str2 + " is " + number + "%";
            return message;
        }

        //get the smallest number
        public static int small(int first, int second, int third)
        {
            int min = Math.Min(first, second);
            return Math.Min(min, third);
        }

        // use Levenshtein algorithm to create the matrix
        public static int calculate(string str1, string str2)
        {
            int[,] Matrix;
            int n = str1.Length;
            int m = str2.Length;

            int temp = 0;
            char ch1;
            char ch2;
            int i = 0;
            int j = 0;
            if (n == 0)
            {
                return m;
            }
            if (m == 0)
            {
                return n;
            }
            Matrix = new int[n + 1, m + 1];

            for (i = 0; i <= n; i++)
            {
                Matrix[i, 0] = i;
            }

            for (j = 0; j <= m; j++)
            {
                Matrix[0, j] = j;
            }

            for (i = 1; i <= n; i++)
            {
                ch1 = str1[i - 1];
                for (j = 1; j <= m; j++)
                {
                    ch2 = str2[j - 1];
                    if (ch1.Equals(ch2))
                    {
                        temp = 0;
                    }
                    else
                    {
                        temp = 1;
                    }
                    Matrix[i, j] = small(Matrix[i - 1, j] + 1, Matrix[i, j - 1] + 1, Matrix[i - 1, j - 1] + temp);
                }
            }

            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= m; j++)
                {
                    Console.Write(" {0} ", Matrix[i, j]);
                }
                Console.WriteLine("");
            }
            return Matrix[n, m];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubsequence
{
    class class_LCS
    {
        private const int LEFT_TO_DOWN = 1;
        private const int TOP_TO_DOWN = 2;
        private const int LEFT_TO_RIGHT = 3;

        public static int LCS1(char[] str1, char[] str2, ref string substr)
        {
            int[,] c = new int[str1.Length, str2.Length];
            int count = -1;
            substr = string.Empty;
            int end = -1;

            for (int i = 0; i < str1.Length; i++)
                for (int j = 0; j < str2.Length; j++)
                    if (str1[i] == str2[j])
                    {
                        if (i == 0 || j == 0) c[i, j] = 1;
                        else
                            c[i, j] = c[i - 1, j - 1] + 1;
                        if (c[i, j] > count)
                        {
                            count = c[i, j];
                            end = i;
                        }

                    }
                    else c[i, j] = 0;
            for (int i = end - count + 1; i <= end; i++)
                substr += str1[i];
            return count;
        }
        public static int[,] LCS(char[] str0, char[] str1)
        {
            int i, j;
            int[,] c = new int[str0.Length + 1, str1.Length + 1];
            int[,] b = new int[str0.Length, str1.Length];

            for (i = 0; i < str0.Length; i++) c[i, 0] = 0;
            for (j = 0; j < str1.Length; j++) c[0, j] = 0;
            for(i= 1; i< str0.Length  +1; i++)
            {
                for(j= 1; j< str1.Length+ 1; j++)
                {
                    if(str0[i] == str1[j])
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                        b[i, j] = LEFT_TO_DOWN;
                    }
                    else
                    {
                        if(c[i-1, j] > c[i, j-1] )
                        {
                            c[i, j] = c[i - 1, j];
                            b[i, j] = TOP_TO_DOWN;
                        }
                        else
                        {
                            c[i, j] = c[i, j - 1];
                            b[i, j] = LEFT_TO_RIGHT;
                            
                        }
                    }
                }
            }
            for(i=0; i< 7; i++)
            {
                for(j= 0; j< 7; j++)
                {
                    Console.Write(b[i, j] + "   ");
                }
                Console.WriteLine();
            }
            return b;
        }
    }
}

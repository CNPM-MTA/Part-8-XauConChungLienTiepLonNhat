using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubsequence//LCS
{
    class Program
    {
        static void Main(string[] args)
        {
            String A = "TOANHOC";
            String B = "KHONHOC";
            char[] str0 = A.ToCharArray();
            char[] str1 = B.ToCharArray();
            string substr = "";

            int lenght = class_LCS.LCS1(str1, str0,ref substr);

            Console.Write("str0= " + A + "\nstr1= " + B+ "\nsubstr = " + substr);
            
            Console.Read();
        }
      
    }
}

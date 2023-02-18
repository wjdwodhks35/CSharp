using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("숫자 2개를 입력해주세요.");
            string chA, chB;
            int nA, nB;
            chA = System.Console.ReadLine();
            chB = System.Console.ReadLine();
            nA = Convert.ToInt32(chA);
            nB = Convert.ToInt32(chB);
            System.Console.WriteLine($"a + b = {__Plus(nA, nB)}");
            System.Console.WriteLine();

            int i = 0;
            int j = 0;
            int k = 0;
            for (k = 0; k < 5; k++)
            {
                for (i = 0; i < 5 - j; i++)
                {
                    System.Console.Write("  ");
                }
                for (i = 0; i < j + 1; i++)
                {
                    System.Console.Write("★");
                }
                j++;
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            i = 0;
            j = 5;
            k = 0;
            for (k = 0; k < 5; k++)
            {
                for (i = 0; i < j; i++)
                {
                    System.Console.Write(" ");
                }
                for (i = 0; i < 6 - j; i++)
                {
                    System.Console.Write("★");
                }
                for (i = 0; i < j; i++)
                {
                    System.Console.Write(" ");
                }
                j--;
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
        static int __Plus(int a, int b)
        {
            return a + b;
        }
    }
}

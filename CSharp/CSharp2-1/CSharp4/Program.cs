using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            for (k = 0; k < 5; k++)
            {
                for(i = 0; i < j+1; i++)
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
                    System.Console.Write("★");
                }
                j--;
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            i = 0;
            j = 0;
            k = 0;
            for(k = 0; k < 5; k++)
            {
                for (i = 0; i < 5 - j; i++)
                {
                    System.Console.Write("  ");
                }
                for (i = 0; i < j+1; i++)
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

            i = 0;
            j = 5;
            k = 0;
            for(k = 0; k < 5; k++)
            {
                for (i = 0; i < 6 - j; i++)
                {
                    System.Console.Write(" ");
                }
                for (i = 0; i < j; i++)
                {
                    System.Console.Write("★");
                }
                for (i = 0; i < 6 - j; i++)
                {
                    System.Console.Write(" ");
                }
                j--;
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
    }
}

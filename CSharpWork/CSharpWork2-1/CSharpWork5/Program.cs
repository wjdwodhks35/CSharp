using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            string chA, chB;
            int nA, nB;
            System.Console.Write("숫자 2개를 입력해 주세요.");
            chA = System.Console.ReadLine();
            chB = System.Console.ReadLine();
            nA = Convert.ToInt32(chA);
            nB = Convert.ToInt32(chB);
            System.Console.WriteLine($"{nA} + {nB} = {nA + nB}");
            System.Console.WriteLine($"{nA} - {nB} = {nA - nB}");
            System.Console.WriteLine($"{nA} * {nB} = {nA * nB}");
            System.Console.WriteLine($"{nA} / {nB} = {nA / nB}");
            System.Console.WriteLine($"{nA} % {nB} = {nA % nB}");
            System.Console.WriteLine();

            string chC;
            int nC;
            System.Console.Write("숫자 1개를 입력해 주세요.");
            chC = System.Console.ReadLine();
            nC = Convert.ToInt32(chC);
            int nD = nC;
            System.Console.WriteLine($"a += a {nD += nC}");
            nD = nC;
            System.Console.WriteLine($"a -= a {nD -= nC}");
            nD = nC;
            System.Console.WriteLine($"a *= a {nD *= nC}");
            nD = nC;
            System.Console.WriteLine($"a /= a {nD /= nC}");
            nD = nC;
            System.Console.WriteLine($"a %= a {nD %= nC}");
            System.Console.WriteLine();
            System.Console.WriteLine($"a++ = {nC++}");
            System.Console.WriteLine($"++a = {++nC}");
            System.Console.WriteLine($"a-- = {nC--}");
            System.Console.WriteLine($"--a = {--nC}");

        }
    }
}

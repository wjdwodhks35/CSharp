using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            string chA, chB;
            int nA, nB;
            System.Console.Write("숫자 2개를 입력해주세요.");
            chA = System.Console.ReadLine();
            chB = System.Console.ReadLine();
            nA = Convert.ToInt32(chA);
            nB = Convert.ToInt32(chB);
            if(nA + nB <= 10)
            {
                System.Console.WriteLine("10이하입니다.");
            }
            else if (nA + nB <= 20)
            {
                System.Console.WriteLine("20이하입니다.");
            }
            else if (nA + nB <= 30)
            {
                System.Console.WriteLine("30이하입니다.");
            }
            else
            {
                System.Console.WriteLine("최소 30이상입니다.");
            }
            System.Console.WriteLine();

            if(nA % 2 == 0 && nB % 2 == 0)
            {
                System.Console.WriteLine("짝짝");
            }
            if (nA % 2 == 0 && nB % 2 == 1)
            {
                System.Console.WriteLine("짝홀");
            }
            if (nA % 2 == 1 && nB % 2 == 0)
            {
                System.Console.WriteLine("홀짝");
            }
            if (nA % 2 == 1 && nB % 2 == 1)
            {
                System.Console.WriteLine("홀홀");
            }
            System.Console.WriteLine();

            System.Console.Write("숫자 1개를 입력해주세요");
            string chC;
            int nC;
            int i = 0;
            chC = System.Console.ReadLine();
            nC = Convert.ToInt32(chC);

            System.Console.WriteLine("while문");
            while(i < nC)
            {
                System.Console.WriteLine("문장반복");
                i++;
            }
            System.Console.WriteLine("for문");
            for(i = 0; i < nC; i++)
            {
                System.Console.WriteLine("문장반복");
            }
            
        }
    }
}

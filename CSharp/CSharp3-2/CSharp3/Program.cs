using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 방항키로 문자 이동

            //ConsoleKeyInfo cski;
            //int x = 10;
            //int y = 10;

            //while (true)
            //{
            //    Console.Clear();

            //    Console.SetCursorPosition(x, y);
            //    Console.Write(".");
            //    cski = Console.ReadKey(true);

            //    switch (cski.Key)
            //    {
            //        case ConsoleKey.LeftArrow:
            //            x--;
            //            break;
            //        case ConsoleKey.RightArrow:
            //            x++;
            //            break;
            //        case ConsoleKey.UpArrow:
            //            y--;
            //            break;
            //        case ConsoleKey.DownArrow:
            //            y++;
            //            break;
            //    }
            //}
            #endregion

            #region 연산자
            //int a = 10;
            //int b = 2;
            //int c = a;
            //System.Console.WriteLine($"a + b = {a + b}");
            //System.Console.WriteLine($"a - b = {a - b}");
            //System.Console.WriteLine($"a * b = {a * b}");
            //System.Console.WriteLine($"a / b = {a / b}");
            //System.Console.WriteLine($"a % b = {a % b}");

            //System.Console.WriteLine($"a += a = {c += a}");
            //c = a;
            //System.Console.WriteLine($"a -= a = {c -= a}");
            //c = a;
            //System.Console.WriteLine($"a *= a = {c *= a}");
            //c = a;
            //System.Console.WriteLine($"a /= a = {c /= a}");
            //c = a;
            //System.Console.WriteLine($"a %= a = {c %= a}");

            //System.Console.WriteLine($"a++ = {a++}");
            //System.Console.WriteLine($"++a = {++a}");
            //System.Console.WriteLine($"a- = {a--}");
            //System.Console.WriteLine($"--a = {--a}");
            #endregion

            #region if, else if, else문
            //string cha, chb;
            //int na, nb;
            //System.Console.Write("숫자 2개를 입력해주세요.");
            //cha = System.Console.ReadLine();
            //chb = System.Console.ReadLine();
            //na = Convert.ToInt32(cha);
            //nb = Convert.ToInt32(chb);

            //if (na % 2 == 0 && nb > 5)
            //{
            //    System.Console.WriteLine("a는 짝수이고 b는 5보다 크다");
            //}
            //else if (na % 2 == 1 && nb < 3)
            //{
            //    System.Console.WriteLine("a는 홀수이고 b는 3보다 작다");
            //}
            //else
            //{
            //    System.Console.WriteLine("없음");
            //}
            #endregion

            #region for, while문
            //string chA;
            //int nA;
            //System.Console.Write("숫자 1개를 입력해주세요.");
            //chA = System.Console.ReadLine();
            //nA = Convert.ToInt32(chA);
            //int i = 0;
            //while (i < nA)
            //{
            //    System.Console.WriteLine("while문");
            //    i++;
            //}
            //for (i = 0; i < nA; i++)
            //{
            //    System.Console.WriteLine("for문");
            //}
            #endregion

            #region 메소드 실행
            //int x = 10;
            //int y = 10;
            //int a = 10;
            //int b = 3;
            //__MoveCursor(x, y);
            //__Operator(a, b);
            //__If(a, b);
            //__For(b);
            #endregion

            #region for, if문

            for(; ;)
            {
                string chA;
                int nA;
                System.Console.Write("숫자 한개를 입력해주세요");
                chA = System.Console.ReadLine();
                nA = Convert.ToInt32(chA);

                if (nA == 10) break;
                if (nA % 2 == 0) continue;
                else System.Console.WriteLine("다음 숫자 입력");
            }
            #endregion
        }
        #region  메소드
        //static int __MoveCursor(int x, int y)
        //{
        //    ConsoleKeyInfo cski;

        //    while (true)
        //    {
        //        Console.Clear();

        //        Console.SetCursorPosition(x, y);
        //        Console.Write("O");
        //        cski = Console.ReadKey(true);

        //        switch (cski.Key)
        //        {
        //            case ConsoleKey.LeftArrow:
        //                x--;
        //                break;
        //            case ConsoleKey.RightArrow:
        //                x++;
        //                break;
        //            case ConsoleKey.UpArrow:
        //                y--;
        //                break;
        //            case ConsoleKey.DownArrow:
        //                y++;
        //                break;
        //        }
        //    }
        //}

        //static int __Operator(int a, int b)
        //{
        //    int c = a;
        //    System.Console.WriteLine($"a + b = {a + b}");
        //    System.Console.WriteLine($"a - b = {a - b}");
        //    System.Console.WriteLine($"a * b = {a * b}");
        //    System.Console.WriteLine($"a / b = {a / b}");
        //    System.Console.WriteLine($"a % b = {a % b}");

        //    c += a;
        //    System.Console.WriteLine($"a += a = {c}");
        //    c -= a;
        //    System.Console.WriteLine($"a -= a = {c}");
        //    c *= a;
        //    System.Console.WriteLine($"a *= a = {c}");
        //    c /= a;
        //    System.Console.WriteLine($"a /= a = {c}");
        //    c %= a;
        //    System.Console.WriteLine($"a %= a = {c}");

        //    System.Console.WriteLine($"a++ = {a++}");
        //    System.Console.WriteLine($"++a = {++a}");
        //    System.Console.WriteLine($"a- = {a--}");
        //    System.Console.WriteLine($"--a = {--a}");
        //    return 0;
        //}

        //static int __If(int na, int nb)
        //{

        //    if (na % 2 == 0 && nb > 5)
        //    {
        //        System.Console.WriteLine("a는 짝수이고 b는 5보다 크다");
        //    }
        //    else if (na % 2 == 1 && nb < 3)
        //    {
        //        System.Console.WriteLine("a는 홀수이고 b는 3보다 작다");
        //    }
        //    else
        //    {
        //        System.Console.WriteLine("없음");
        //    }
        //    return 0;
        //}
        //static int __For(int nA)
        //{

        //    int i = 0;
        //    while (i < nA)
        //    {
        //        System.Console.WriteLine("while문");
        //        i++;
        //    }
        //    for (i = 0; i < nA; i++)
        //    {
        //        System.Console.WriteLine("for문");
        //    }
        //    return 0;
        //}
        #endregion
    }
}

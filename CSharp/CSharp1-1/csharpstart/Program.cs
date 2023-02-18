using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstart
{
    class Program
    {
        static void Main(string[] args)
        {
            //변수형 종류 주석으로 작성후 각 변수형들의 최대값 최소값 출력하기
            int nA = int.MinValue; // 정수
            int nB = int.MaxValue;
            char chA = char.MinValue; // 문자
            char chB = char.MaxValue;
            float fA = float.MinValue; // 실수(4비트)
            float fB = float.MaxValue;
            double dA = double.MinValue; // 실수(8비트)
            double dB = double.MaxValue;

            System.Console.WriteLine($@"int의 최소값 : {nA} int의 최대값 {nB}
char의 최소값 : {chA} char의 최소값 {chB}
float의 최소값 : {fA} float의 최대값 {fB}
double의 최소값 : {dA} double의 최대값 {dB}");
            System.Console.WriteLine();

            //string으로 출생년도 입력 받고 나이 출력하기
            string BoneYear;
            int Result = 2023;
            System.Console.Write("당신의 출생년도는? : ");
            BoneYear = System.Console.ReadLine();
            Result = (Result - Convert.ToInt32(BoneYear));
            System.Console.WriteLine($"당신의 나이는 {Result}입니다.");
            System.Console.WriteLine();

            //@사용해서 별그리기
            System.Console.WriteLine(@"     .     
    ...    
 ......... 
    ...   
   .   .");
            System.Console.WriteLine();

            //int값을 double로 캐스팅 하기
            int casting = 10;
            System.Console.WriteLine(Convert.ToDouble(casting));
            System.Console.WriteLine();

            // 이름을 입력받고 이름의 길이를 구한 뒤 출력한다.
            string sName;
            System.Console.Write("당신의 이름은? : ");
            sName = System.Console.ReadLine();
            int Namelength = sName.Length;
            System.Console.WriteLine($"당신의 이름은 {Namelength}글자입니다.");
        }
    }
}

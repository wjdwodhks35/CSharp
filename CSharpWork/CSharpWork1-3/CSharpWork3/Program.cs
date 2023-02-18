using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            System.Console.Write("당신의 이름은? ");
            Name= System.Console.ReadLine();
            System.Console.WriteLine("");
            string Age;
            System.Console.Write("당신의 나이는? ");
            Age = System.Console.ReadLine();
            System.Console.WriteLine("");
            string Gender;
            System.Console.Write("당신의 성별은? ");
            Gender = System.Console.ReadLine();
            System.Console.WriteLine("");
            string Address;
            System.Console.Write("당신의 주소는? ");
            Address = System.Console.ReadLine();
            System.Console.WriteLine("");

            System.Console.WriteLine($"당신의 이름 : {Name}");
            System.Console.WriteLine($"당신의 나이 : {Age}");
            System.Console.WriteLine($"당신의 성별 : {Gender}");
            System.Console.WriteLine($"당신의 주소 : {Address}");

        }
    }
}

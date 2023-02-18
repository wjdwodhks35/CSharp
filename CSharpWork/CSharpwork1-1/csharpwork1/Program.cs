using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Select;
            int nSelect;
            string[] menu = new string[4] { "떡볶이", "김밥", "라면", "라뽁이" };

            System.Console.WriteLine($@"1. {menu[0]} 2. {menu[1]} 3. {menu[2]} 4. {menu[3]}
무엇을 주문하시겠습니까? ");

            Select = System.Console.ReadLine();
            nSelect = Convert.ToInt32(Select);
            nSelect -= 1;
            System.Console.WriteLine($@"{menu[nSelect]}를 먹었다.");
            menu[nSelect] = " ";

            System.Console.WriteLine($@"1. {menu[0]} 2. {menu[1]} 3. {menu[2]} 4. {menu[3]}
남은 메뉴 ");
        }
    }
}

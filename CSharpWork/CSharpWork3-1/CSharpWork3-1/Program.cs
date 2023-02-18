using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpWork3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Year
            //Year years = new Year();
            //years.InputBornYearData();
            //years.GetZodiacsign();
            //years.GetAge();
            //years.WriteInfo();
            #endregion
            #region Calculator
            //Calculator calculators = new Calculator();
            //calculators.InputData();
            //calculators.Calculators();
            //calculators.WriteResult();
            #endregion
            Korean koreans = new Korean();
            Western westerns = new Western();
            Chinese chineses = new Chinese();
            int inputMenu;

            System.Console.WriteLine(@"    무엇을 드시겠습니까
1. 한식   2. 양식   3. 중식");
            int inputFood = Convert.ToInt32(System.Console.ReadLine()) - 1;
            switch (inputFood)
            {
                case 0:
                    koreans.SetMenu();
                    koreans.ShowMenu();

                    System.Console.WriteLine();
                    System.Console.Write("무엇을 주문하시겠습니까");
                    inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
                    koreans.ShowOrder(inputMenu);
                    break;
                case 1:
                    westerns.SetMenu();
                    westerns.ShowMenu();

                    System.Console.WriteLine();
                    System.Console.Write("무엇을 주문하시겠습니까");
                    inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
                    westerns.ShowOrder(inputMenu);
                    break;
                case 2:
                    chineses.SetMenu();
                    chineses.ShowMenu();

                    System.Console.WriteLine();
                    System.Console.Write("무엇을 주문하시겠습니까");
                    inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
                    chineses.ShowOrder(inputMenu);
                    break;
            }
        }
    }
    #region Calculator
    //class Calculator
    //{
    //    public string chC;
    //    public int nA, nB, nResult;

    //    public void InputData()
    //    {
    //        System.Console.Write("숫자 2개를 입력해주세요.");
    //        nA = Convert.ToInt32(System.Console.ReadLine());
    //        nB = Convert.ToInt32(System.Console.ReadLine());
    //        System.Console.Write("수식을 입력해주세요.(+, -, *, /, %)");
    //        chC = System.Console.ReadLine();
    //    }
    //    public void Calculators()
    //    {
    //        switch (chC)
    //        {
    //            case "+":
    //                nResult = nA + nB;
    //                break;
    //            case "-":
    //                nResult = nA - nB;
    //                break;
    //            case "*":
    //                nResult = nA * nB;
    //                break;
    //            case "/":
    //                nResult = nA / nB;
    //                break;
    //            case "%":
    //                nResult = nA % nB;
    //                break;

    //        }
    //    }
    //    public void WriteResult()
    //    {
    //        System.Console.WriteLine($"{nA} {chC} {nB} = {nResult}");
    //    }
    //}
    #endregion
    #region Year
    //class Year
    //{
    //    public int BornYear;
    //    public int Age;
    //    public string Zodiacsign;

    //    public void InputBornYearData()
    //    {
    //        System.Console.Write("태어난 년도를 입력해주세요.");
    //        string chA = System.Console.ReadLine();
    //        BornYear = Convert.ToInt32(chA);
    //    }
    //    public void GetZodiacsign()
    //    {
    //        switch (BornYear % 12)
    //        {
    //            case 0:
    //                Zodiacsign = "원숭이";
    //                break;
    //            case 1:
    //                Zodiacsign = "닭";
    //                break;
    //            case 2:
    //                Zodiacsign = "개";
    //                break;
    //            case 3:
    //                Zodiacsign = "돼지";
    //                break;
    //            case 4:
    //                Zodiacsign = "쥐";
    //                break;
    //            case 5:
    //                Zodiacsign = "소";
    //                break;
    //            case 6:
    //                Zodiacsign = "호랑이";
    //                break;
    //            case 7:
    //                Zodiacsign = "토끼";
    //                break;
    //            case 8:
    //                Zodiacsign = "용";
    //                break;
    //            case 9:
    //                Zodiacsign = "뱀";
    //                break;
    //            case 10:
    //                Zodiacsign = "말";
    //                break;
    //            case 11:
    //                Zodiacsign = "양";
    //                break;
    //        }
    //    }
    //    public void GetAge()
    //    {
    //        Age = 2023 - BornYear;
    //    }
    //    public int GetAge2(int nBornyear)
    //    {
    //        return 2024 - BornYear;
    //    }
    //    public void WriteInfo()
    //    {
    //        System.Console.WriteLine($"당신의 출생년도는 {BornYear}입니다");
    //        System.Console.WriteLine($"당신의 나이(만)는 {Age}입니다");
    //        System.Console.WriteLine($"당신의 띠는 {Zodiacsign}입니다");
    //    }
    //}
    #endregion
    class Restaurant
    {
        protected int[] Pride;
        protected string[] Menu;

        protected void TakeMoney(int nPride)
        {
            System.Console.WriteLine($"-{Pride[nPride]}원");
        }
        protected void OrderMenu(int menu)
        {
            System.Console.WriteLine($"{Menu[menu]}를 주문하셨습니다.");
        }
        public void ShowMenu()
        {

            System.Console.WriteLine("         메뉴판");
            for (int i = 0; i < Menu.Count(); i++)
            {
                System.Console.Write($"{i + 1}. {Menu[i]}     ");
            }
        }
    }
    class Korean : Restaurant
    {
        public void SetMenu()
        {
            Menu = new string[2];
            Menu[0] = "비빔밥";
            Menu[1] = "볶음밥";
            Pride = new int[2];
            Pride[0] = 4000;
            Pride[1] = 5000;
        }
        public void ShowOrder(int nMenu)
        {
            OrderMenu(nMenu);
            TakeMoney(nMenu);
        }

    }
    class Western : Restaurant
    {
        public void SetMenu()
        {
            Menu = new string[2];
            Menu[0] = "스파게티";
            Menu[1] = "미트볼";
            Pride = new int[2];
            Pride[0] = 9000;
            Pride[1] = 6000;
        }
        public void ShowOrder(int nMenu)
        {
            OrderMenu(nMenu);
            TakeMoney(nMenu);
        }
    }
    class Chinese : Restaurant
    {
        public void SetMenu()
        {
            Menu = new string[2];
            Menu[0] = "짜장면";
            Menu[1] = "짬뽕";
            Pride = new int[2];
            Pride[0] = 7000;
            Pride[1] = 8000;
         }
        public void ShowOrder(int nMenu)
        {
            OrderMenu(nMenu);
            TakeMoney(nMenu);
        }
    }
}


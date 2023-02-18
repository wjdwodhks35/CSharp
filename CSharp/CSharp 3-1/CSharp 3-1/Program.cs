using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Food 실행
            //Food foods = new Food();
            //foods.InputFoodlist();
            //foods.AddFoodlist();
            //foods.ComparisonFood();
            //foods.WriteFoodList();
            #endregion
            #region Year 실행
            //Year years = new Year();
            //years.InputBornYearData();
            //years.GetZodiacsign();
            //years.GetAge();
            //years.WriteInfo();
            #endregion
            #region Game 실행
            //Game games = new Game();
            //games.SetGamelist();
            //games.ComparisonGamelist();
            #endregion
            #region Classes 실행
            // Classes myclass = new Classes();
            //myclass.WriteSchoolInfo("신대초등학교");
            #endregion
            #region Restaurant 실행
            //            Korean koreans = new Korean();
            //            Western westerns = new Western();
            //            Chinese chineses = new Chinese();
            //            int inputMenu;

            //            System.Console.WriteLine(@"         무엇을 드시겠습니까
            //1. 한식   2. 양식   3. 중식");
            //            int inputFood = Convert.ToInt32(System.Console.ReadLine()) -1;
            //            switch (inputFood)
            //            {
            //                case 0:
            //                    koreans.SetMenu();
            //                    koreans.ShowMenu();

            //                    System.Console.WriteLine();
            //                    System.Console.Write("무엇을 주문하시겠습니까");
            //                    inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
            //                    koreans.OrderMenu(inputMenu);
            //                    break;
            //                case 1:
            //                    westerns.SetMenu();
            //                    westerns.ShowMenu();

            //                    System.Console.WriteLine();
            //                    System.Console.Write("무엇을 주문하시겠습니까");
            //                    inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
            //                    westerns.OrderMenu(inputMenu);
            //                    break;
            //                case 2:
            //                    chineses.SetMenu();
            //                    chineses.ShowMenu();

            //                    System.Console.WriteLine();
            //                    System.Console.Write("무엇을 주문하시겠습니까");
            //                    inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
            //                    chineses.OrderMenu(inputMenu);
            //                    break;
            //            }
            //
            #endregion
            #region Book 실행
            //Bookstore books = new Bookstore();
            //books.SetBookInfo();
            //books.Roof();
            #endregion
            #region Classes 실행
            //Classes school = new Classes();

            //school.WriteClass();
            //school.SearchClass();
            #endregion
        }
    }
    #region Student 클래스
    class Student
    {
        public string chName;
        public int nClass;
    }
    class Classes
    {
        Student[] students = new Student[99];
        public int writenumber = 0;

        public void WriteClass()
        {
            while (true)
            {
                students[writenumber] = new Student();
                System.Console.WriteLine("학생의 이름을 입력해주세요.");
                students[writenumber].chName = System.Console.ReadLine();
                System.Console.WriteLine("학생의 반을 입력해주세요.");
                students[writenumber].nClass = Convert.ToInt32(System.Console.ReadLine());
                writenumber++;
                System.Console.WriteLine("더 입력하시겠습니까? y/n");
                string chChoice = System.Console.ReadLine();
                if (chChoice == "y") continue;
                if (chChoice == "n") break;
            }
        }
        public void SearchClass()
        {
            System.Console.WriteLine("반을 입력해주세요.");
            int nSearch = Convert.ToInt32(System.Console.ReadLine());
            for(int i = 0; i < writenumber; i++)
            {
                if(nSearch == students[i].nClass) System.Console.WriteLine($"{students[i].chName}");
            }
            System.Console.WriteLine("모두 찾았습니다.");
        }
    }
    #endregion
    #region Restaurant 클래스
    //class Restaurant
    //{
    //    protected int[] Pay;
    //    protected string[] Menu;

    //    protected void TakeMoney(int Pride)
    //    {
    //        System.Console.WriteLine($"-{Pay[Pride]}원");
    //    }
    //    protected void OrderMenu(int menu)
    //    {
    //        System.Console.WriteLine($"{Menu[menu]}를 주문하셨습니다.");
    //        TakeMoney(menu);
    //    }
    //    public void ShowMenu()
    //    {

    //        System.Console.WriteLine("         메뉴판");
    //        for(int i = 0; i <Menu.Count(); i++)
    //        {
    //            System.Console.Write($"{i+1}. {Menu[i]}     ");
    //        }
    //    }


    //}
    //class Korean : Restaurant
    //{
    //    public void SetMenu()
    //    {
    //        Menu = new string[2];
    //        Menu[0] = "비빔밥";
    //        Menu[1] = "볶음밥";
    //        Pay = new int[2];
    //        Pay[0] = 4000;
    //        Pay[1] = 5000;
    //    }

    //}
    //class Western : Restaurant
    //{
    //    public void SetMenu()
    //    {
    //        Menu = new string[2];
    //        Menu[0] = "스파게티";
    //        Menu[1] = "미트볼";
    //        Pay = new int[2];
    //        Pay[0] = 9000;
    //        Pay[1] = 6000;
    //    }
    //}
    //class Chinese : Restaurant
    //{
    //    public void SetMenu()
    //    {
    //        Menu = new string[2];
    //        Menu[0] = "짜장면";
    //        Menu[1] = "짬뽕";
    //        Pay = new int[2];
    //        Pay[0] = 7000;
    //        Pay[1] = 8000;
    //    }

    //}
    #endregion
    #region School 클래스
    //class School
    //{
    //    protected string SchoolName;

    //    protected void WriteSchoolName()
    //    {
    //        System.Console.WriteLine($"학교 이름 : {SchoolName}");
    //    }
    //}
    //class Classes : School
    //{
    //    private string ClassName = "3반";

    //    public void WriteSchoolInfo(string _schoolName)
    //    {
    //        SchoolName = _schoolName;
    //        WriteSchoolName();
    //        System.Console.WriteLine($"내 반은 {ClassName}");
    //    }
    //}
    #endregion
    #region Food 클래스
    //class Food
    //{
    //    public string[] foodlist;
    //    public string addfood;

    //    public void InputFoodlist()
    //    {
    //        foodlist = new string[5];
    //        for(int i = 0; i < 5; i++)
    //        { 
    //            System.Console.Write("음식을 입력해주세요.");
    //            foodlist[i] = System.Console.ReadLine();
    //        }
    //    }
    //    public void AddFoodlist()
    //    {
    //        System.Console.Write("추가 음식을 입력해주세요.");
    //        addfood = System.Console.ReadLine();
    //    }
    //    public void ComparisonFood()
    //    {
    //        int delete = Array.IndexOf(foodlist, addfood);
    //        foodlist[delete] = "";
    //    }
    //    public void ComparisonFood()
    //    {
    //        string delete = Array.Find(foodlist, element => element == addfood);
    //        for(int i = 0; i < 5; i++)
    //        {
    //            if (foodlist[i] == delete)
    //            {
    //                foodlist[i] = "";
    //                break;
    //            }
    //      }
    //    }
    //    public void WriteFoodList()
    //    {
    //        for(int i = 0; i < 5; i++)
    //        {
    //            System.Console.WriteLine($"{i}. {foodlist[i]}");
    //        }
    //    }
    //}
    #endregion
    #region Year 클래스
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
    //        switch(BornYear % 12)
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
    #region Game 클래스
    //class Game
    //{
    //    public string[] Gamelist;

    //    public void SetGamelist()
    //    {
    //        Gamelist = new string[6];
    //        Gamelist[0] = "리그오브레전드";
    //        Gamelist[1] = "스타크래프트";
    //        Gamelist[2] = "스타크래프트2";
    //        Gamelist[3] = "발로란트";
    //        Gamelist[4] = "오버워치";
    //        Gamelist[5] = "배틀그라운드";
    //    }
    //    public void ComparisonGamelist()
    //    {
    //        string game;
    //        System.Console.Write("게임을 입력해주세요.");
    //        game = System.Console.ReadLine();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            if (Gamelist[i] == game)
    //            {
    //                System.Console.WriteLine($"{game}을(를) 보유하고 있습니다.");
    //                break;
    //            }
    //            if(i == 4)
    //            {
    //                System.Console.WriteLine($"{game}을(를) 보유하고 있지 않습니다.");
    //            }
    //        }
    //    }
    //}
    #endregion
    #region book 클래스
    //class Book
    //{
    //    public string Bookname;
    //    public string Bookwriter;
    //    public string Bookpublisher;
    //}
    //class Bookstore
    //{
    //    Book[] book = new Book[99];

    //    public void Roof()
    //    {
    //        while(true)
    //        {
    //            bool writebook = true;
    //            string choice;
    //            int roofcount = 0;
    //            while (writebook = true)
    //            {
    //                System.Console.WriteLine("책 제목을 입력해주세요");
    //                book[roofcount].Bookname = System.Console.ReadLine();
    //                System.Console.WriteLine("책 제목을 입력해주세요");
    //                book[roofcount].Bookname = System.Console.ReadLine();
    //                System.Console.WriteLine("책 제목을 입력해주세요");
    //                book[roofcount].Bookname = System.Console.ReadLine();
    //                System.Console.WriteLine("----------------------");
    //                roofcount++;
    //                System.Console.WriteLine("더 입력하시겠습니까? y/n");
    //                System.Console.WriteLine("검색을 하시려면 r을 눌러주세요.");
    //                choice = System.Console.ReadLine();
    //                if (choice == "y") continue;
    //                else if (choice == "n") break;
    //                else if (choice == "r")
    //                {
    //                    writebook = false;
    //                }
    //                else
    //                {
    //                    System.Console.WriteLine("올바른 값을 입력해주세요.");
    //                    break;
    //                }
    //            }
    //            while(writebook = false)
    //            {
    //                int bookname;
    //                System.Console.WriteLine("책 제목을 입력해주세요");
    //                string searchbookname = System.Console.ReadLine();

    //                for(int i = 0; i < roofcount; i++)
    //                {
    //                    if(book[i].Bookname == searchbookname)
    //                    {
    //                        bookname = i;
    //                    }
    //                }
    //                System.Console.WriteLine($"책 제목 : {book[bookname].Bookname}");
    //                System.Console.WriteLine($"책 저자 : {Bookwriter[booknumber]}");
    //                System.Console.WriteLine($"책 출판사 : {Bookpublisher[booknumber]}");
    //                System.Console.WriteLine("----------------------");

    //                System.Console.WriteLine("더 검색하시겠습니까? y/n");
    //                choice = System.Console.ReadLine();
    //                if (choice == "y") continue;
    //                else if (choice == "n") break;
    //                else
    //                {
    //                    System.Console.WriteLine("올바른 값을 입력해주세요.");
    //                    break;
    //                }
    //            }

    //        }
    //    }
    //}
    #endregion
}

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
            Student Astudent;
            Astudent = new Student();
            Astudent.name = "손건희";
            Astudent.age = 19;

            System.Console.WriteLine($"A학생의 이름은 {Astudent.name}");
            System.Console.WriteLine($"A학생의 나이는 {Astudent.age}");

            Astudent.WritelineStudentInfo();

            Student Bstudent = new Student();
            Bstudent.name = "NewName";
            Bstudent.age = 25;

            System.Console.WriteLine($"B학생의 이름은 {Bstudent.name}");
            System.Console.WriteLine($"B학생의 나이는 {Bstudent.age}");

        }
    }
    class Student
    {
        public string name;
        public int age;

        public void WritelineStudentInfo()
        {
            System.Console.WriteLine($"학생의 이름은 {name}");
            System.Console.WriteLine($"학생의 나이는 {age}");

        }
    }
}

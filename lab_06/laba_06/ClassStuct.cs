using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace laba_06
{
    public class ClassStuct
    {
        public enum PopularEnum 
        {
            popular,
            notPopular,
            average
        }
        public struct Student
        {
            string NameStudent;
            string Department;
            int Course;
            int PopularBook;
            List<string> NameBookDebt;
            public void GetInformation ()
            {
                Console.WriteLine($" Name Student: {NameStudent} \n Department: {Department} \n Course: {Course} \n NameBookDebt:");
                switch(PopularBook)
                {
                    case (int)PopularEnum.popular:
                        Console.WriteLine(" Эти книги популярны!");
                        break;
                    case (int)PopularEnum.average:
                        Console.WriteLine(" У этих книг средняя популярность!");
                        break;
                    case (int)PopularEnum.notPopular:
                        Console.WriteLine(" Эти книги не популярны!");
                        break;
                    default:
                        Console.WriteLine(" Ошибка!!! \n Введенные данные не верны!");
                        break;
                }
                foreach (var debt in NameBookDebt)
                    Console.WriteLine($"\t{debt.ToString()}");
            }
            public Student(string NameStudent, string Department, int Course, int PopularBook, params string [] NameBook)
            {
                NameBookDebt = new List<string>();
                this .NameStudent = NameStudent;
                this .Department = Department;  
                this .Course = Course;
                this.PopularBook = PopularBook;
                foreach (var name in NameBook)
                    this .NameBookDebt.Add(name);
            }
        }
    }
}

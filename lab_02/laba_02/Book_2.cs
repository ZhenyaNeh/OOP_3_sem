using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Name
{
    partial class Book
    {
        /*в одном из методов класса для работы с аргументами используйте ref -
       и out-параметры.*/
        public void Chenge_Biding_Type(ref string old_Type, string new_Type)
        {
            old_Type = new_Type;
        }

        public void Chenge_Autors(out string old_Autor, string new_Autor)
        {
            old_Autor = new_Autor;
        }

        //Создайте статический метод вывода информации о классе.
        public static void ShowClassInfo()
        {
            Console.WriteLine($"---- Поля класса ----\n" +
            $"ID\n" +
            $"autors\n" +
            $"name_Book\n" +
            $"publishing_House\n" +
            $"publishing_Year\n" +
            $"numbers_Of_Pages\n" +
            $"price\n" +
            $"biding_Type\n" +
            $"---- Методы класса ----\n" +
            $"ShowClassInfo\n" +
            $"Chenge_Biding_Type\n" +
            $"Chenge_Autors\n"
            );
        }

        /*переопределите методы класса Object: Equals, для сравнения объектов,
        GetHashCode, ToString – вывода строки информации об объекте.*/

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Book book = obj as Book;

            return book.id == this.id;
        }
        public override int GetHashCode()
        {
            return (int)(this.publishing_Year * this.numbers_Of_Pages / this.price);
        }

        public override string ToString()
        {
            return $"id книги: {this.id}\n" +
                    $"Автор: {this.autors}\n" +
                    $"Наззвание: {this.name_Book}\n" +
                    $"Публикация: {this.publishing_House}\n" +
                    $"Год публикации: {this.publishing_Year}\n" +
                    $"Количество страниц: {this.numbers_Of_Pages}\n" +
                    $"Цена ($): {this.price}\n" +
                    $"Тип переелета: {this.biding_Type}\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace My_Name
{
    partial class Book
    {
        private string autors;
        private string name_Book;
        private string publishing_House;
        private int publishing_Year;
        private int numbers_Of_Pages;
        private int price;
        private string biding_Type;      //Тип переплета

        /*поле - только для чтения(например, для каждого экземпляра сделайте
        поле только для чтения ID - равно некоторому уникальному номеру
        (хэшу) вычисляемому автоматически на основе инициализаторов объекта);*/
        private readonly int id;

        /*создайте в классе статическое поле, хранящее количество созданных
        объектов(инкрементируется в конструкторе)*/
        public static int count;

        /* Не менее трех конструкторов(с параметрами и без, а также с
        параметрами по умолчанию);*/
        
        static Book()
        {
            count = 0;
        }

        public Book()
        {
            autors = "Jules Verne";
            name_Book = "Вокруг света за 80 дней";
            publishing_House = "Maybe interesting plase";
            publishing_Year = 1588;
            numbers_Of_Pages = 450;
            price = 18;
            biding_Type = "Hard cover";
            count++;
            id = GetHashCode();
        }

        private Book( string autors = "Jules Verne")
        {
            this.autors = autors;
            name_Book = "Вокруг света за 80 дней";
            publishing_House = "Maybe interesting plase";
            publishing_Year = 1588;
            numbers_Of_Pages = 550;
            price = 18;
            biding_Type = "Hard cover";
            count++;
            id = GetHashCode();
        } 

        public Book(string autors, string name_Book, string publishing_House, int price, string biding_Type, int publishing_Year = 1867,
        int numbers_Of_Pages = 600)
        {
            this.autors = autors;
            this.name_Book = name_Book;
            this.publishing_House = publishing_House;
            this.publishing_Year = publishing_Year;
            this.numbers_Of_Pages = numbers_Of_Pages;
            this.price = price;
            this.biding_Type = biding_Type;
            count++;
            id = GetHashCode();
        }

        public Book(int check_Value)
        {
            if (check_Value > 0)
            {
                autors = "Mark Tven";
                name_Book = "Приключения Тома Сойера";
                publishing_House = "Maybe interesting plase";
                publishing_Year = 215;
                numbers_Of_Pages = 550;
                price = 15;
                biding_Type = "Hard cover";
                count++;
                id = GetHashCode();
            }
        }

        //статический конструктор(конструктор типа);
        

        

        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        //СВОЙСТВА
        //свойства (get, set) – для всех поле класса (поля класса должны быть закрытыми)

        public string name_Autors
        {
            get { return this.autors; }
            private set 
            {
                if (this.autors == "Mark Tven")
                {
                    this.autors = "Mark Tven";
                }
                else
                {
                    this.autors = "Jule Vern";
                }
            }
        }

        public string name_Bookssssss
        {
            get { return this.name_Book; }
            private set 
            {
                if (this.name_Book == "")
                {
                    this.name_Book = "name unknow";
                }
            }
        }

        public string name_Publishing_House
        {
            get { return this.publishing_House; }
            set
            {
                if (this.publishing_House == "")
                {
                    this.publishing_House = "Maybe interesting plase";
                }
            }
        }

        public int name_Publishing_Year
        {
            get { return this.publishing_Year; }
            set
            {
                if (this.publishing_Year == 0)
                {
                    this.publishing_Year = 1867;
                }
            }
        }

        public int name_Numbers_Of_Pages
        {
            get { return this.numbers_Of_Pages; }
            set
            {
                if (this.numbers_Of_Pages == 0)
                {
                    this.numbers_Of_Pages = 250;
                }
            }
        }

        public int name_Price
        {
            get { return this.price; }
            set
            {
                if (this.price == 0)
                {
                    this.price = 55;
                }
            }
        }

        public string name_Biding_Type
        {
            get { return this.biding_Type; }
            set
            {
                if (this.biding_Type == "")
                {
                    this.biding_Type = "Hard cover";
                }
            }
        }

    }
}

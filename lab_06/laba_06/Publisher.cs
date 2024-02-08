using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace laba_06
{
    internal abstract class Publisher
    {
        internal string _NamePublisher;
        internal string NamePublisher
        {
            get { return _NamePublisher; }
            set
            {
                if (value == "")
                    throw new StringException("Строка не должна быть пустой!!!");
                else
                    _NamePublisher = value;
            }
        }

        internal int _CountOfCopies;
        public int CountOfCopies
        { 
            get { return _CountOfCopies; }
            set 
            {
                if (value <= 0)
                    throw new CountOfCopiesException("You indicated the uncorrect count of copies!!!\n(Check that the entered number is greater than zero!)", value);
                else
                    _CountOfCopies = value;
            } 
        }

        public int _PublisherYear;
        public int PublisherYear 
        {
            get { return _PublisherYear; }
            set
            {
                if (value <= 1950 || value > 2023)
                    throw new PublisherYearException($"Year {value} out of range!!!\n(Check that the entered year is in the range from 1950 to 2023)", value);
                else
                    _PublisherYear = value;
            }
        }

        public int _Cost;
        public int Cost 
        {
            get { return _Cost; }
            set
            {
                if(value < 0)
                    throw new CostException("You indicated the uncorrect price!!!\n(Check that the entered number is greater than zero!)", value);
                else
                    _Cost = value;
            }
        }

        internal string _NameBook;
        internal string NameBook 
        {
            get { return _NameBook; }
            set
            {
                if (value == "")
                    throw new StringException("Строка не должна быть пустой!!!");
                else
                    _NameBook = value;
            }
        }

        internal string _NameAuthor;
        internal string NameAuthor
        {
            get { return _NameAuthor; }
            set
            {
                if (value == "")
                    throw new StringException("Строка не должна быть пустой!!!");
                else
                    _NameAuthor = value;
            }
        }

        internal string _Gender;
        internal string Gender
        {
            get { return _Gender; }
            set
            {
                if (value == "")
                    throw new StringException("Строка не должна быть пустой!!!");
                else
                {
                    char firstChar = char.ToUpper(value[0]);

                    if (firstChar != 'М' && firstChar != 'M' && firstChar != 'W' && firstChar != 'Ж')
                    {
                        throw new TestException("Вы указали не правильный пол автора!");
                    }
                    else
                        _Gender = value;
                }  

            }
        }

        internal Publisher(string _NamePublisher, int _CountOfCopies, int _PublisherYear, int _Cost, string _NameBook,  string _NameAuthor, string _Gender) 
        {
            this.NamePublisher = _NamePublisher;
            this.CountOfCopies = _CountOfCopies;
            this.PublisherYear = _PublisherYear;
            this.Cost = _Cost;
            this.NameBook = _NameBook;
            this.NameAuthor = _NameAuthor;
            this.Gender = _Gender;
        }

        public override string ToString()
        {
            return $"Название идателя: {_NamePublisher} \n" +
                   $"Количество копий: {_CountOfCopies} \n" +
                   $"Год издания: {_PublisherYear} \n" +
                   $"Цена: {_Cost} \n" +
                   $"Название книги: {_NameBook} \n" + 
                   $"Имя автора: {_NameAuthor} \n" ;
        }
        public override bool Equals(object obj)
        {
            if (obj is Publisher publisher)
                return CountOfCopies == publisher._CountOfCopies;
            return false;
        }
        public override int GetHashCode() => _PublisherYear.GetHashCode();
    }
}

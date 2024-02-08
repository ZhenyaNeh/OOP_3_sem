using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_v2
{
    sealed internal class Magazine : PrintedEdition, ICheckPopularity
    {
        internal string Topic { get; set; }
        public Author author;
        internal Magazine (string NamePublisher, int CountOfCopies, int CountOfEmployees, string NameAuthor, string Gender, string Topic)
            : base(NamePublisher, CountOfCopies, CountOfEmployees, NameAuthor, Gender)
        {
            this.Topic = Topic;
        }

        internal Magazine(Author author, string AreaOfResearch) : base(author.NamePublisher, author.CountOfCopies, author.CountOfEmployees, author.NameAuthor, author.Gender)
        {
            this.author = author;
            this.Topic= AreaOfResearch;
        }

        bool ICheckPopularity.CheckPopularity()
        {
            return CountOfCopies >= 3000;
        }

        internal override bool CheckPopularity()
        {
            if (CountOfCopies >= 3000 && CountOfEmployees >= 20)
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"Название идателя: {NamePublisher} \n" +
                   $"Количество копий: {CountOfCopies} \n" +
                   $"Количество работников: {CountOfEmployees} \n" +
                   $"Имя автора: {NameAuthor} \n" +
                   $"Тема дня: {Topic} \n";
        }
    }
}

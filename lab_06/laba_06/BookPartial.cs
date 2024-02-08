using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_06
{
    internal partial class Book : PrintedEdition, ICheckPopularity
    {
        bool ICheckPopularity.CheckPopularity()
        {
            return CountOfCopies >= 3000;
        }

        internal override bool CheckPopularity()
        {
            if (CountOfCopies >= 3000 && PublisherYear >= 20)
                return true;

            return false;
        }

        public override string ToString()
        {
            Console.WriteLine("".PadLeft(15, '_') + "book" + "".PadLeft(15, '_'));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"Название идателя: {_NamePublisher} \n" +
                $"Количество копий: {_CountOfCopies} \n" +
                $"Год издания: {_PublisherYear} \n" +
                $"Цена: {_Cost} \n" +
                $"Имя автора: {_NameAuthor} \n" +
                $"Жанр: {NameGanre} \n");
            Console.ForegroundColor = ConsoleColor.White;

            return $"Название идателя: {_NamePublisher} \n" +
                   $"Количество копий: {_CountOfCopies} \n" +
                   $"Год издания: {_PublisherYear} \n" +
                   $"Цена: {_Cost} \n" +
                   $"Имя автора: {_NameAuthor} \n" +
                   $"Жанр: {NameGanre} \n";
        }
    }
}

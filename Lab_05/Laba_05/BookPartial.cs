using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_05
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
            return $"Название идателя: {NamePublisher} \n" +
                   $"Количество копий: {CountOfCopies} \n" +
                   $"Год издания: {PublisherYear} \n" +
                   $"Цена: {Cost} \n" +
                   $"Имя автора: {NameAuthor} \n" +
                   $"Жанр: {NameGanre} \n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13
{
    [Serializable]
    public class Book : PrintedEdition
    {
        [NonSerialized]
        public string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        [NonSerialized]
        public PrintedEdition PrintedEdition;

        public Book(string? publishType, int cost, int countPages, string genre) 
            : base(publishType, cost, countPages)
        {
            PublishType = publishType;
            Cost = cost;
            CountPages = countPages;
            Genre = genre;
        }

        public Book(PrintedEdition printedEdition, string genre)
            : base(printedEdition.PublishType, printedEdition.Cost, printedEdition.CountPages)
        {
            PrintedEdition = printedEdition;
            Genre = genre;
        }

        public Book() {}

        public override string ToString()
        {
            return $"Publish Type: {PublishType} \n" +
                   $"Cost: {Cost}$ \n" +
                   $"Count Pages: {CountPages} \n" +
                   $"Genre: {Genre} \n";
        }
    }
}

using System.Collections;
using System.Threading.Tasks.Dataflow;

namespace laba_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            string[] mounth = {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            var first = from n in mounth 
                        where n.Length == 8
                        select n;
            var second = mounth.Where(n => n[0] == 'J' || n[0] == 'F' || n[0] == 'D' || n == "August").Select(x => x);
            var third = mounth.OrderBy(x => x);
            var fouth = mounth.Where(n => n.Contains('u') && n.Length == 4).Select(x => x);

            StaticClass.Show($"Сортировка по длинне {first.First().Length}", first);
            StaticClass.Show($"\nСортировка по летним/зимним месяцам: ", second);
            StaticClass.Show($"\nСортировка по алфовиту: ", third);
            StaticClass.Show($"\nСортировка по 'u' и длинне 4: ", fouth);

            var bookMain = new Book("Name", "Book", "Author", 2000, 100, 0);
            var col = new Collectiom<Book>();
            col.AddManyElement(10, bookMain);
            col.Add(new Book("Name", "Book", "Author", 2000, 1, 0));
            col.Add(new Book("Name", "Book", "Author", 2000, 3000, 5));
            col.Add(new Book("Name", "Book", "Author", 2000, 4000, 6));
            col.Add(new Book("Name", "Book", "Author", 2000, 1100, 6));
            col.Print();

            Console.Write("\n Third Task\n");

            string authorName = "Author_6";
            int publiserYear = 2008;
            var firstTask = col.Where(x => x.Autor == authorName || x.Year == publiserYear).Select(x => x);
            var secondTask = col.Where(x => x.Year > publiserYear).Select(x => x);
            var thirdTask = col.OrderBy(x => x.CountPages).First();
            var forthTask = col.OrderByDescending(x => x.CountPages).ThenBy(x => x.Cost).Take(5);
            var fifthTask = col.OrderBy(x => x.Cost).Select(x => x);

            StaticClass.Show($"\nCписок книг заданного автора: \"{authorName}\" и года: \"{publiserYear}\"", firstTask);
            StaticClass.Show($"\nCписок книг, выпущенных после \"{publiserYear}\" года", secondTask);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nCамую тонкую книгу__________\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(thirdTask);
            StaticClass.Show($"\n5 первых самых толстых книг по низкой цене", forthTask);
            StaticClass.Show($"\nСписок книг отсортированных по цене", fifthTask);

            Console.Write("\n Fouth Task\n");
            var myRequest = col.Where(x => x.Year > 2003)
                .OrderByDescending(x => x.CountPages)
                .Skip(1)
                .Take(2)
                .ToList();

            StaticClass.Show($"\nМой запрос", myRequest);

            MyClassCost[] test =
            {
                    new MyClassCost(1, "мало"),
                    new MyClassCost(2, "мало"),
                    new MyClassCost(3, "мало"),
                    new MyClassCost(4, "нормально"),
                    new MyClassCost(5, "нормально"),
                    new MyClassCost(6, "нормально"),
                    new MyClassCost(7, "нормально"),
                    new MyClassCost(8, "нормально"),
                    new MyClassCost(9, "много"),
                    new MyClassCost(10, "много")
            };

            var result = col.Join(test,
                x => x.Cost,
                p => p.CostCheck,
                (x, p) => new { Name = x.NameBook, ResultCost = p.CostCheck, HowMoney = p.Expensive }).Take(4);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("_____________Join_____________");
            Console.ForegroundColor = ConsoleColor.White;
            foreach(var element in result)
                Console.WriteLine($"Name: {element.Name} \nCost: {element.ResultCost} \nHow: {element.HowMoney}\n");
        }
    }
}
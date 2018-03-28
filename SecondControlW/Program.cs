
namespace SecondControlW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book{Name = "lallallalka", Year = 1956, Author = "Lal1"},
                new Book{Name = "LINQ First Edition", Year = 2000,Author = "Lal2"},
                new Book{Name = "Some Old Book", Year = 1900,Author = "Lal3"},
                new Book{Name = "Older Book than old book", Year = 1805,Author = "Lal4"},
                new Book{Name = "LINQ Second Edition", Year = 2016, Author = "Lal5"},
                new Book{Name = "Year Year", Year = 1956, Author = "Lal6"},
                new Book{Name = "Test Book", Year = 2017 ,Author = "Lal7"},
            };

            Console.WriteLine("Have word LINQ and LeapYear");
            var LinqAndLeapY = books
                .Where(name => name.Name.Contains("LINQ"))
                .Where(year => year.Year % 4 == 0)
                .ToList();
            LinqAndLeapY.ForEach(Console.WriteLine);

            string input = "Сколько букв алфавита понадобилось для написания этого текста";
            Console.WriteLine(input);
            var result = from _ in input
                         group _ by _ into g
                         let count = g.Count()
                         orderby g.Key
                         select new
                         {
                             Value = g.Key,
                             Count = count
                         };
            result.ToList().ForEach(Console.WriteLine);

            Console.WriteLine("Sorting numbers ");
            int[] numbers = { 12, 15, 25, 13, 96, 24, 43 };
            var res = numbers
                .OrderBy(_ => _ % 10)
                //.ThenBy(...)
                .ToList();
            res.ForEach(Console.WriteLine);

            var resultAuthors = from _ in books
                                group _ by _ into g
                                let count = g.Count()
                                orderby g.Key
                                select new
                                {
                                    Value = g.Key,
                                    Count = count
                                };

            resultAuthors.ForEach(Console.WriteLine);
            Console.ReadKey();
        }

    }
}

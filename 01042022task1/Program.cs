

using System;

namespace _01042022task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Name = "Cəsur yeni dünya",
                AuthorName = "Oldos Haksli",
                PageCount = 156
            };
            Book book2 = new Book()
            {
                Name = "Siçanlar və adamlar",
                AuthorName = "Con Steynbek",
                PageCount = 300
            };

            Book book3 = new Book()
            {
                Name = "Səfillər",
                AuthorName = "Viktor Hüqo",
                PageCount = 500
            };
            Library libraff = new Library();
            libraff.Books.Add(book1);
            libraff.Books.Add(book2);
            libraff.Books.Add(book3);
        }
    }
}

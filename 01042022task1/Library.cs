using System;
using System.Collections.Generic;
using System.Text;

namespace _01042022task1
{
    class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Book> FindAllBooksByName(string value)
        {
            List<Book>newBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Name.Contains(value))
                {
                    newBooks.Add(book);
                }
            }
            return newBooks;

        }
        public void RemoveAllBookByName(string value)
        {
            
            foreach (Book book in Books)
            {
                if (book.Name.Contains(value))
                {
                    Books.Remove(book);
                }
            }
        
        }
        public List<Book> SearchBooks(string value)
        {
            List<Book> newBooks = new List<Book>();
            foreach (Book book in Books)
            {
                string text = book.Name + book.AuthorName + book.PageCount;
                if (text.Contains(value))
                {
                    newBooks.Add(book);
                }
            }
            return newBooks;

        }
        public List<Book> FindAllBooksByPageCountRange(int  minPg,int maxPg)
        {
            List<Book> newList = new List<Book>();
            foreach (Book book in Books)
            {
                
                if (book.PageCount>minPg && book.PageCount<maxPg)
                {
                    newList.Add(book);
                }
            }
            return newList;

        }







    }
}

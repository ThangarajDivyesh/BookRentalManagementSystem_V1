using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class BookManager
    {
        public List<Book> books=new List<Book>();

        public void CreateBook(Book book)
        {

          books.Add(book);
            Console.WriteLine("Book added successfully");
        }

        public void ReadBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("List of books");
            }
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void UpdateBook(string bookId,string title,string author,decimal rentalprice)
        {
           if(books.Count != 0)
            {
                var book = books.FirstOrDefault(b=>b.Equals(bookId));
            }

           else
            {
                Console.WriteLine("enetr correct id");
            }
        }

        public void DeleteBook(string bookId)
        {
            if(books.Count != 0)
            {
                var book = books.FirstOrDefault(c=>c.Equals(bookId));
                books.Remove(book);
                Console.WriteLine("remove book");
            }
            else
            {
                Console.WriteLine("enter correct id");
            }
        }
        

    }
}

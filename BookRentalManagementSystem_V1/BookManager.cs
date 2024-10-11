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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class BookManager
    {
        public List<Book> books= new List<Book>();
      

        public void CreateBook(string bookId, string title, string author, decimal rentalPrice)
        {
            Book book = new Book(bookId, title, author, rentalPrice);
            books.Add(book);
            Console.WriteLine("book add sucsee");
        }

        public void ReadBook()
        {
            if (books.Count == 0)
            {
                books = new List<Book>();
            }
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
        


       

            
        

        public void UpdateBook(string bookId,string title,string author,decimal rentalprice)
        {
            var book = books.FirstOrDefault(s => s.Equals(bookId));
            if (book == null)
            {
                Console.WriteLine("");
            }
            else
            {
                Book book1= new Book(bookId,title,author, rentalprice);
                books.Add(book1);
            }
           
        }

        public void DeleteBook(string bookId)
        {
            if(books.Count != 0)
            {
                var book = books.FirstOrDefault(c=>c.Equals(bookId));
                books.Remove(book);
                Console.WriteLine(bookId);
            }
            else
            {
                Console.WriteLine("enter correct id");
            }
        }

       
    }
}

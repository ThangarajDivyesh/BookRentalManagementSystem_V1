using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class PrintedBook :Book 
    {
        private int ISBN {  get; set; }
        private int NumberOfPages { get; set; }

        public PrintedBook(string bookId, string title, string author, decimal rentalPrice,int ISBN, int NumberOfPages)
            :base (bookId, title, author,rentalPrice)
        {
            this.NumberOfPages = NumberOfPages;
            this.ISBN = ISBN;
        }
    }
}

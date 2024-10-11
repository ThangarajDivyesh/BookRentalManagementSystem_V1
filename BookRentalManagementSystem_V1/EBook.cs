using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class EBook :Book
    {
        
    
        private double FileSize {  get; set; }
        private string Format { get; set; }

       public EBook(string bookId, string title, string author, decimal rentalPrice,double FileSize, string Format)

           : base(bookId, title,author,rentalPrice)

            {
            
            this.FileSize = FileSize;
            this.Format = Format;
            
            }
        public override string DisplayDigitalBookInfo()
        {
            return $"{base.DisplayDigitalBookInfo()},filesize{FileSize},format{Format}";
        }






    }
}

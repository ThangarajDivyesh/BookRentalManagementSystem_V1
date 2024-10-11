using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();
            int option;
            while (true)
                
            {
                try
                {
                    Console.WriteLine("BookRental Managment");
                    Console.WriteLine("1. Add a Book :");
                    Console.WriteLine("2. View All Books :");
                    Console.WriteLine("3. Update a Book :");
                    Console.WriteLine("4. Delete a Book:");
                    Console.WriteLine("5. Exit :");
                    Console.WriteLine("Choose an option:");

                    option = Convert.ToInt32(Console.ReadLine());

                    switch(option)
                    {
                        case 1:
                            Console.WriteLine("Enter Book ID :");
                            string bookid = Console.ReadLine();
                            Console.WriteLine("Enter Book Title: ");
                            string title = Console.ReadLine();
                            Console.WriteLine("Enter Book Author: ");
                            string author = Console.ReadLine();
                            Console.WriteLine("Enter Book rental price: ");
                            decimal rentalprice = decimal.Parse(Console.ReadLine());
                           
                            bookManager.CreateBook(bookid, title, author, rentalprice);
                            break;
                        case 2:
                            Console.WriteLine("List of Books:");
                            bookManager.ReadBook();
                            break;
                        case 3:
                            Console.WriteLine("Enter the Book ID to update");
                            string updateid = Console.ReadLine();
                            Console.WriteLine("Enter new Title: ");
                            string newtitle = Console.ReadLine();
                            Console.WriteLine("Enter new Author: ");
                            string newauthor = Console.ReadLine();
                            Console.WriteLine("Enter new rental Price:");
                            decimal newrentalprice = decimal.Parse(Console.ReadLine());
                            bookManager.UpdateBook(updateid, newtitle, newauthor, newrentalprice);
                            break;
                        case 4:
                            Console.WriteLine("Enter the Book ID to delete: ");
                            string deleteid = Console.ReadLine();
                            bookManager.DeleteBook(deleteid);
                            break;
                        case 5:
                            Console.WriteLine("exit");
                            break;
                            


                    }
                    
                }catch(Exception)
                {

                Console.WriteLine(); 
            }
            }
        }
    }
}

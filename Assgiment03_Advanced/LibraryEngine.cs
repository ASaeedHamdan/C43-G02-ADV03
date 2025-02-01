using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment03_Advanced
{
    internal class LibraryEngine
    {
        public delegate string BookPointerFunction(Book b);

        public static void ProcessBooks(List<Book> books, BookPointerFunction DelegateParam)
        {
            foreach (var book in books)
            {
                Console.WriteLine(DelegateParam(book));
            }
        }
        public static void ProcessBooks(List<Book> books, Func<Book, string> DelegateParam)
        {
            foreach (var book in books)
            {
                Console.WriteLine(DelegateParam(book)); 
            }
        }
    }
}

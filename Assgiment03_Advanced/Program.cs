using static System.Reflection.Metadata.BlobBuilder;

namespace Assgiment03_Advanced
{
    public delegate int StringFunctionCase(string s);
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<Book> books = new List<Book>
                {
                    new Book("123", "C#", ["saeed", "ahmed"], new DateTime(2023, 12, 10), 50.11M),
                    new Book("456", "JavaScript", ["Mohamed", "Hassan"], new DateTime(2025, 2, 1), 23.25M)
                };

           

            #region User-Defined Delegate Datatype
            //LibraryEngine.BookPointerFunction fPtr1 = BookFunctions.GetTitle;

            //LibraryEngine.ProcessBooks(books, fPtr1);
            #endregion

            #region BCL Delegates
            // i define new function that take list of books and Func Delegate to deal with it  as Overloading
            //Func<Book, string> fPtr2 = BookFunctions.GetAuthors;

            //LibraryEngine.ProcessBooks(books, fPtr2);

            #endregion
            //Func<Book, string> fPtr2 = BookFunctions.GetPrice;

            //LibraryEngine.ProcessBooks(books, fPtr2);

            #region Anonymous Method
            //LibraryEngine.BookPointerFunction fPtr3 = delegate (Book b) { return b.ISBN; };

            //LibraryEngine.ProcessBooks(books, fPtr3);
            #endregion

            #region  Lambda Expression

            //Func<Book, string> fPtr4 = (Book b) => b.PublicationDate.ToString();  // DD / MM / YYYY  Hours / Minutes / Seconds
            //Func<Book, string> fPtr4 = (Book b) => b.PublicationDate.ToShortDateString(); // DD / MM / YYYY 
            //LibraryEngine.ProcessBooks(books, fPtr4);
            #endregion
        }
    }
}

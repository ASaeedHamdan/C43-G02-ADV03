using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment03_Advanced
{
    internal class Book
    {
        #region Properties
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string[]? Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructor
        public Book(string isbn, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }
        #endregion


        #region Methods
        public override string ToString()
        {
            // i use string.join in Authors to concatenate the elements of the Authors array
            return $"Title: {Title}, ISBN: {ISBN}, Authors: {string.Join(" - ", Authors)}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price}";
        }
        #endregion


    }
}

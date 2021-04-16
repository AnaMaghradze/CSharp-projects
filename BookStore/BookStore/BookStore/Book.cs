using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Ana Maghradze
/// red ID: 82335646
/// </summary>
namespace BookStore
{
    class Book
    {
        // Author, ISBN, Price, and Title.
        public string Author { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        
        // Book explicit value constructor
        public Book(string title, string author, string price, string isbn)
        {
            Title = title;
            Author = author;
            Price = price;
            ISBN = isbn;
        }

        // Book default constructor
        public Book() { }

        public override string ToString()
        {
            return base.ToString();
        }        
    }
}

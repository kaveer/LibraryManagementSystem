using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Class
{
    internal class Book : LibraryItem
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private string ISBN { get; set; }
        private bool IsAvailable { get; set; }

        public Book(string id, string title, bool isAvailable, string author, string isbn) : base(id, title, isAvailable)
        {
            SetAuthor(author);
            SetISBN(isbn);
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public void SetAuthor(string author)
        {
            Author = author;
        }

        public string GetISBN()
        {
            return ISBN;
        }

        public void SetISBN(string isbn)
        {
            ISBN = isbn;
        }

        public bool GetIsAvailable()
        {
            return IsAvailable;
        }

        public void SetIsAvailable(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Author: {GetAuthor()}");
            Console.WriteLine($"ISBN: {GetISBN()}");
        }
    }
}

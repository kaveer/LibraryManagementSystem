using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Class
{
    internal class LibraryItem
    {
        private string Id { get; set; }
        private string Title { get; set; }
        private bool IsAvailable { get; set; }

        public LibraryItem(string id, string title, bool isAvailable)
        {
            SetTitle(title);
            SetId(id);
            SetIsAvailable(isAvailable);
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public string GetId()
        {
            return Id;
        }

        public void SetId(string id)
        {
            Id = id;
        }

        public string GetIsAvailable()
        {
            return IsAvailable? "Yes": "No";
        }

        public void SetIsAvailable(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {GetId()}");
            Console.WriteLine($"Title: {GetTitle()}");
            Console.WriteLine($"Is available: {GetIsAvailable()}");
        }
    }
}

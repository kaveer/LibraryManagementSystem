using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Class
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string Publisher { get; set; }

        public Magazine(string publisher, int issueNumber, string id, string title, bool isAvailable):base(id, title, isAvailable)
        {

            SetIssueNumber(issueNumber);
            SetPublisher(publisher);
        }

        public int GetIssueNumber() { 
            return IssueNumber; 
        }

        public void SetIssueNumber(int issueNumber)
        {
            IssueNumber = issueNumber;
        }

        public string GetPublisher()
        {
            return Publisher;
        }

        public void SetPublisher(string publisher)
        {
            this.Publisher = publisher;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Issue number: {GetIssueNumber()}");
            Console.WriteLine($"Publisher: {GetPublisher()}");
            
        }
    }
}

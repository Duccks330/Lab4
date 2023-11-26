using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Customer
    {
        private static int Count = 0;

        public int ID { get; set; }

        public string FirstName { get; set; }

        private string LastName { get; set; }

        private string EmailAddress { get; set; }

        private string PhoneNumber { get; set; }

        public DateTime Date = DateTime.Now;

        private bool ContactStatus { get; set; }


        public int Counter()
        {
            Count += 1;
            return Count;

        }


        public Customer(string First, string Last, string Email, string Phone, bool Contacted)
        { 
            // Set constructor Variables
            ID = Count;
            FirstName = First;
            LastName = Last;
            EmailAddress = Email;
            PhoneNumber = Phone;
            ContactStatus = Contacted;

            


        }

    }
}

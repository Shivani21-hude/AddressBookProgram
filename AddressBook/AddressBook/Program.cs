using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("      'Welcome to Address Book program'");
            Console.WriteLine("\n");
            AddressBook.Person.CreateContacts();
            AddressBook.Person.editContact();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Person
    {
        public static List<Contact> person = new List<Contact>();
        internal static void CreateContacts(int times)
        {

            Contact contact = new Contact();
            for (int i = 1; i < times; times++)
            {

                Console.WriteLine("Enter First Name :");
                contact.firstname = Console.ReadLine();

                Console.WriteLine("Enter Last Name :");
                contact.lastname = Console.ReadLine();

                Console.WriteLine("Enter Address :");
                contact.address = Console.ReadLine();

                Console.WriteLine("Enter city :");
                contact.city = Console.ReadLine();

                Console.WriteLine("Enter state :");
                contact.state = Console.ReadLine();

                Console.WriteLine("Enter zipcode :");
                contact.zipcode = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Mobile Number :");
                contact.phonenumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter email :");
                contact.email = Console.ReadLine();

                person.Add(contact);
                Console.WriteLine("........................");
            }
        }

        //Edit contact details
        
        public static void editContact()
        {
            Console.WriteLine("Enter the First Name: ");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.firstname == name)
                    {
                       Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option =  Convert.ToInt32(Console.ReadLine());
                      
                        switch (option)
                        {
                            case 1:
                                string fName = Console.ReadLine();
                                data.firstname = fName;
                                break;

                            case 2:
                                string lName = Console.ReadLine();
                                data.lastname = lName;
                                break;

                            case 3:
                                string address = Console.ReadLine();
                                data.address = address;
                                break;

                            case 4:
                                string City = Console.ReadLine();
                                data.city = City;
                                break;

                            case 5:
                                string State = Console.ReadLine();
                                data.state = State;
                                break;

                            case 6:
                                int Zipcode = Convert.ToInt32(Console.ReadLine());
                                data.zipcode = Zipcode;
                                break;

                            case 7:
                                int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                data.phonenumber = PhoneNumber;
                                break;

                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name doesnot match");
                    }
                }
            }
        }
        
      //if name of person will match the first one then it will delete
        public static void DeleteContact()
        {
            Contact contacts = new Contact();
            Console.WriteLine("Enter FirstName of paerson whose contact deleted ");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.firstname == name)
                    {
                            person.Remove(contacts);
                            Console.WriteLine("Contact is remove");
                        
                    }
                    else

                    {
                        Console.WriteLine("Contact is not present");
                    }
                }

            }
        }
    }
}

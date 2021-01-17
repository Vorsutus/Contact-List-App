using System.Collections.Generic;
using System.Linq; //need Linq to set list order

namespace ContactsApp.Model
{
    public static class ContactData
    {
        //public static IList<Contact> Contacts { get; set; }

        public static IList<Contact> contacts = new List<Contact>();

        public static IList<Contact> Contacts
        {
            get
            {
                //reorder the data before returning it
                contacts = new List<Contact>(contacts.OrderBy(contact => contact.LastName));
                return contacts;
            }
            set
            {
                contacts = value;
            }
        }

        static ContactData()
        {
            Contacts = new List<Contact>();

            Contacts.Add(new Contact
            {
                FirstName = "Tim",
                LastName = "Chenoweth",
                ContactType = "Me"
            });
            Contacts.Add(new Contact
            {
                FirstName = "Heather",
                LastName = "Chenoweth",
                ContactType = "Wife"
            });
            Contacts.Add(new Contact
            {
                FirstName = "Holly",
                LastName = "Chenoweth",
                ContactType = "Daughter"
            });
            Contacts.Add(new Contact
            {
                FirstName = "Jake",
                LastName = "Chenweth",
                ContactType = "Son"
            });
            Contacts.Add(new Contact
            {
                FirstName = "Lacy",
                LastName = "Chenoweth",
                ContactType = "Dog"
            });
            Contacts.Add(new Contact
            {
                FirstName = "Jeff",
                LastName = "Holt",
                ContactType = "Class Mate"
            });
            Contacts.Add(new Contact
            {
                FirstName = "Brian",
                LastName = "Perkins",
                ContactType = "Class Mate"
            });

            //Contacts = Contacts.OrderBy(contact => contact.LastName).ToList();
        }
    }
}

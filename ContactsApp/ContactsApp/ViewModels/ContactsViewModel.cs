using System.Collections.Generic;
using ContactsApp.ViewModels;
using ContactsApp.Model;
using ContactsApp.Views;
using Xamarin.Forms;
using System.Windows.Input;
using System;

namespace ContactsApp.ViewModels
{
    public class ContactsViewModel : ViewModelBase
    {
        //public IList<Contact> Contacts => ContactData.Contacts;

        Contact contact = new Contact();
        private static Contact selectedContact;
        private static Contact saveContact = new Contact();

        public ICommand AddContactCommand { protected set; get; }
        public ICommand DeleteContactCommand { protected set; get; }
        public ICommand CancelEditCommand { protected set; get; }

        public ContactsViewModel()
        {
            AddContactCommand = new Command(() =>
            {
                Contacts.Add(contact);
                Contact = new Contact();
            });

            DeleteContactCommand = new Command(() =>
            {
                Contacts.Remove(selectedContact);
            });

            CancelEditCommand = new Command(() =>
            {
                selectedContact.FirstName = saveContact.FirstName;
                selectedContact.LastName = saveContact.LastName;
                selectedContact.ContactType = saveContact.ContactType;
            });
        }

        public Contact Contact
        {
            get => contact;
            set
            {
                contact = value;
                OnPropertyChanged();
            }
        }

        public static IList<Contact> Contacts
        {
            get => ContactData.Contacts;
            set => ContactData.Contacts = value;
        }

        public Contact SelectedContact
        {
            get => selectedContact;
            set
            {                
                if (value != null)
                {
                    saveContact.FirstName = value.FirstName;
                    saveContact.LastName = value.LastName;
                    saveContact.ContactType = value.ContactType;
                }
                selectedContact = value;
                OnPropertyChanged();
            }
        }
    }
}

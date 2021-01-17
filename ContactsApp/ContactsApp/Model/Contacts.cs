namespace ContactsApp.Model
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactType { get; set; }
        public string FullName { get => FirstName + " " + LastName; }

        public Contact()
        {

        }

        public Contact(string firstName, string lastName, string contactType)
        {
            FirstName = firstName;
            LastName = lastName;
            ContactType = contactType;
        }
    }
}

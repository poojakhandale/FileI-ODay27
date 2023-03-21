using FileIODemo;

namespace Day27AddressBookFileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddressBook myAddressBook = new AddressBook();
            Contacts newContact = new Contacts("Pooja", "khandale", "INDIA", "8369319177", "Pooja.p@example.com");
            Contacts newContact2 = new Contacts("Ronit", "Das", "USA", "888222444", "ronit.das@jr.com");
            //Contacts newContact3 = new Contacts("Ronit", "Das", "USA", "888222444", "ronit.das@jr.com");

            myAddressBook.AddContact(newContact);
            myAddressBook.AddContact(newContact2);

            myAddressBook.PrintContacts();


            string path = "C:\\c#practicle\\FileIODemo\\FileIODemo\\Addressbook.csv";

        }
    } 
}
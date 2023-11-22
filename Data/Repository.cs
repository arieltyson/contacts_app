using System.Text;
using System.Threading.Tasks;
using contacts_app.Models;
using Contact = contacts_app.Models.Contact;

namespace contacts_app.Data
{
	public static class ContactRepository
	{
		public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact { ContactId = 1, Name="Baker Smith", Email="bsmith@microsoft.com"},
            new Contact { ContactId = 2, Name="Ariel Tyson", Email="atyson@microsoft.com"},
            new Contact { ContactId = 3, Name="Randall Hill", Email="rhill@microsoft.com"},
            new Contact { ContactId = 4, Name="Sam Altman", Email="saltman@openai.com"},
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {
            return _contacts.FirstOrDefault(x => x.ContactId == contactId);
        }
    }
}


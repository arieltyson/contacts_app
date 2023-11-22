using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_app.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();

        List<Contact> contacts = new List<Contact>()
        {
            new Contact { Name="Baker Smith", Email="bsmith@microsoft.com"},
            new Contact { Name="Ariel Tyson", Email="atyson@microsoft.com"},
            new Contact { Name="Randall Hill", Email="rhill@microsoft.com"},
        };

        ContactsList.ItemsSource = contacts;
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
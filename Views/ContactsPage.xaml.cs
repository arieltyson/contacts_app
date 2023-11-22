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

        List<string> contacts = new List<string>()
        {
            "John Wall",
            "Conor McGregor",
            "Kibe Bean Bryant",
            "Alibaba"
        };

        ContactsList.ItemsSource = contacts;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_app.Views;

public partial class PhoneBook : ContentPage
{
    public PhoneBook()
    {
        InitializeComponent();

        List<string> contacts = new List<string>()
        {
            "John Doe",
            "Jane Doe",
            "John Smith",
            "Jane Smith",
        };
        ListContacts.ItemsSource=contacts;
    }
}
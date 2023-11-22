using contacts_app.Data;
using contacts_app.Models;
using Contact = contacts_app.Models.Contact;

namespace contacts_app.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();

        List<Contact> contacts = ContactRepository.GetContacts();

        ContactsList.ItemsSource = contacts;
    }

    async void ContactsList_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        if (ContactsList.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)ContactsList.SelectedItem).ContactId}");
        }
    }

    void ContactsList_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        ContactsList.SelectedItem = null;
    }
}
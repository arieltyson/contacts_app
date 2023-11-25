using System.Collections.ObjectModel;
using contacts_app.Data;
using contacts_app.Models;
using Contact = contacts_app.Models.Contact;

namespace contacts_app.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadContacts();
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

    void addButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    void DeleteButton_Clicked(System.Object sender, System.EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var contact = menuItem.CommandParameter as Contact;
        ContactRepository.DeleteContact(contact.ContactId);

        LoadContacts();
    }

    private void LoadContacts()
    {
        var contacts = new ObservableCollection<Contact>(ContactRepository.GetContacts());
        ContactsList.ItemsSource = contacts;
    }
}
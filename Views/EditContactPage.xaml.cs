using contacts_app.Data;
using contacts_app.Models;
using Contact = contacts_app.Models.Contact;

namespace contacts_app.Views;

[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContactPage : ContentPage
{
    private Contact contact;

    public EditContactPage()
    {
        InitializeComponent();
    }

    private void cancelButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    public string ContactId
    {
        set
        {
            contact = ContactRepository.GetContactById(int.Parse(value));
            if (contact != null)
            {
                entryName.Text = contact.Name;
                entryAddress.Text = contact.Address;
                entryEmail.Text = contact.Email;
                entryPhone.Text = contact.Phone;
            }
        }
    }

    void updateButton_Clicked(System.Object sender, System.EventArgs e)
    {
        contact.Name = entryName.Text;
        contact.Address = entryAddress.Text;
        contact.Email = entryEmail.Text;
        contact.Phone = entryPhone.Text;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }
}
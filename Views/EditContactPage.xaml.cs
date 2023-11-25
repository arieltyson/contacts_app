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
                contactCtrl.Name = contact.Name;
                contactCtrl.Address = contact.Address;
                contactCtrl.Email = contact.Email;
                contactCtrl.Phone = contact.Phone;
            }
        }
    }

    void updateButton_Clicked(System.Object sender, System.EventArgs e)
    {
        contact.Name = contactCtrl.Name;
        contact.Address = contactCtrl.Address;
        contact.Email = contactCtrl.Email;
        contact.Phone = contactCtrl.Phone;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }
}
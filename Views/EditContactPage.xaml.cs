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

    private void BtnCancel_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    public string ContactId
    {
        set
        {
            contact = ContactRepository.GetContactById(int.Parse(value));
            labelName.Text = contact.Name;
        }
    }
}
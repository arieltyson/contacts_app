using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_app.Views;

public partial class AddContactPage : ContentPage
{
    public AddContactPage()
    {
        InitializeComponent();
    }

    private void BtnCancel_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}
namespace contacts_app.Views.Controls;

public partial class ContactControl : ContentView
{

    public event EventHandler<string> OnSave;
    public event EventHandler<EventArgs> OnCancel;

	public ContactControl()
	{
		InitializeComponent();
	}

	public string Name
	{
		get
		{
			return entryName.Text;
		}
		set
		{
			entryName.Text = value;
		}
	}

    public string Email
    {
        get
        {
            return entryEmail.Text;
        }
        set
        {
            entryEmail.Text = value;
        }
    }

    public string Address
    {
        get
        {
            return entryAddress.Text;
        }
        set
        {
            entryAddress.Text = value;
        }
    }

    public string Phone
    {
        get
        {
            return entryPhone.Text;
        }
        set
        {
            entryPhone.Text = value;
        }
    }

    void cancelButton_Clicked(System.Object sender, System.EventArgs e)
    {
        OnCancel?.Invoke(sender, e);
    }

    void saveButton_Clicked(System.Object sender, System.EventArgs e)
    {
        OnSave?.Invoke(sender, e.ToString());
    }
}

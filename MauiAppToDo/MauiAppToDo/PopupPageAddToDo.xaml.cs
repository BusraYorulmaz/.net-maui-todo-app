using CommunityToolkit.Maui.Views;
namespace MauiToolkitPopupSample;

public partial class PopupPageAddToDo :Popup
{
	public PopupPageAddToDo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Close();	
    }
}
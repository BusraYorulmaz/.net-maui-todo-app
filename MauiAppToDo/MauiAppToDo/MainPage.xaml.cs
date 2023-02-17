using System.ComponentModel;

namespace MauiAppToDo;

public partial class MainPage : ContentPage
{
	public string Password ="1234";
	public static string pass = "1234";
    public MainPage()
	{
		InitializeComponent();
	}

    private void BtnMoveToToDoPage_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new ToDoPage());
        /*if (EnterPassword.Text = pass) 
		{
			Navigation.PushAsync(new ToDoPage());
		}
		else 
		{
			Navigation.PushAsync(new MainPage());
        }*/

    }
}


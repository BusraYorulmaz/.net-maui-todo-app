using CommunityToolkit.Maui.Views;
using MauiAppToDo.ViewModel;
using MauiToolkitPopupSample;
using System.ComponentModel;

namespace MauiAppToDo;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    private void BtnMoveToToDoPage_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ToDoPage(new MainViewModel(),EnterUserName.Text));
    }
}


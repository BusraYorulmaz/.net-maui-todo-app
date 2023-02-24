using CommunityToolkit.Maui.Views;
using MauiAppToDo.ViewModel;
using MauiToolkitPopupSample;

namespace MauiAppToDo;

public partial class ToDoPage : ContentPage
{
    public ToDoPage(MainViewModel mvm, string userName)
	{
		InitializeComponent();
        BindingContext= mvm;
        //LvToDoList.ItemsSource = toDoList;

        LblUserName.Text = userName; //ismi diðer sayfaya taþýrken
    }

     private void BtnClickedPopup(object sender, EventArgs e)
    {
         this.ShowPopup(new PopupPageAddToDo());
    }
}
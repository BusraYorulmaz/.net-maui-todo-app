using CommunityToolkit.Maui.Views;
using MauiToolkitPopupSample;


namespace MauiAppToDo;

public partial class ToDoPage : ContentPage
{
	List<ToDoListClass> toDoList = new List<ToDoListClass>() 
	{ 
		new ToDoListClass(){ ToDoName =" Read a magazine"},
        new ToDoListClass(){ ToDoName =" Study for exam"},
        new ToDoListClass(){ ToDoName =" Attend the internship meeting"},
		new ToDoListClass(){ ToDoName =" Do sport"}
    }; 
	public ToDoPage()
	{
		InitializeComponent();
		LvToDoList.ItemsSource = toDoList;
    }

    private void BtnClickedPopup(object sender, EventArgs e)
    {
        this.ShowPopup(new PopupPageAddToDo());
    }
}
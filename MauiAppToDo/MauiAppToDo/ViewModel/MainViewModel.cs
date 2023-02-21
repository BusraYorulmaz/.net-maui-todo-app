using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppToDo.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    String to_do;

    [ObservableProperty]    
    ObservableCollection<String> todoItems;


    //complated
    /*[ObservableProperty]
    ObservableCollection<String> complatedItems;*/

    public MainViewModel() 
    {
        TodoItems= new ObservableCollection<String>();  
        //ComplatedItems= new ObservableCollection<String>();
    }

    [RelayCommand]
    void AddToDo()
    {
        TodoItems.Add(To_do);
        To_do = string.Empty;
    }

    /*[RelayCommand]
    void AddComplated()
    {
        ComplatedItems.Add(To_do);
        To_do= string.Empty;
    }*/

  

}

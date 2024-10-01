using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace PlaygroundAv.ViewModels;

public partial class MainViewModel : ViewModelBase
{

    [ObservableProperty] private ObservableCollection<ItemViewModel> _itemSource;

    [RelayCommand]
    private void Start()
    {
        ItemSource = new()
        {
            new() { Name = "Number", Value = 0, DisplayType = false },
            new() { Name = "String", Value = "Test", DisplayType = true },
            new() { Name = "Date", Value = DateTimeOffset.Now, DisplayType = false, IsDate = true },
        };
    }
}

public partial class ItemViewModel : ObservableObject
{
    [ObservableProperty] private string _name;
    [ObservableProperty] private object? _value;

    /// <summary>
    /// False -> Number
    /// True ->  String
    /// </summary>
    [ObservableProperty] private bool _displayType;
    [ObservableProperty] private bool _isDate;
}



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
            new() { Name = "Number", Value = 0, IsNumber = true },
            new() { Name = "String", Value = "Test", IsString = true },
            new() { Name = "Number String", Value = "123", IsString = true, IsNumber = true},
            new() { Name = "Date", Value = DateTimeOffset.Now, IsDate = true },
        };
    }
}

public partial class ItemViewModel : ObservableObject
{
    [ObservableProperty] private string _name;
    [ObservableProperty] private object? _value;

    [ObservableProperty] private bool _isNumber = false;
    [ObservableProperty] private bool _isString = false;
    [ObservableProperty] private bool _isDate = false;
}



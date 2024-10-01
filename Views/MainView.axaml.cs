using Avalonia.Controls;
using PlaygroundAv.ViewModels;
using System;

namespace PlaygroundAv.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void NumericUpDown_ValueChanged(object? sender, Avalonia.Controls.NumericUpDownValueChangedEventArgs e)
    {
        Console.WriteLine("Number Changed");
    }

    private void TextBox_TextChanged(object? sender, Avalonia.Controls.TextChangedEventArgs e)
    {
        Console.WriteLine("Text Changed");
    }

    private void DatePicker_SelectedDateChanged(object? sender, Avalonia.Controls.DatePickerSelectedValueChangedEventArgs e)
    {
        Console.WriteLine("Date Changed");
    }
}

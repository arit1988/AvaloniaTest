using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication1.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddManyClick(object? sender, RoutedEventArgs e)
    {
        for (int i = 0; i < 10; i++)
        {
            this.Panel.Children.Add(new Button(){Content = $"{i}"});
        }
    }

    private void RemoveManyClick(object? sender, RoutedEventArgs e)
    {
        this.Panel.Children.Clear();
        GC.Collect();
    }
}
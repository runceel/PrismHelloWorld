﻿using PrismHelloWorld.Main.ViewModels;
using Windows.UI.Xaml.Controls;

namespace PrismHelloWorld.Main.Views
{
    public sealed partial class MainView : UserControl
    {
        private MainViewModel ViewModel => (MainViewModel)DataContext;
        public MainView()
        {
            this.InitializeComponent();
        }
    }
}

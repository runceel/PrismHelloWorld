﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace PrismHelloWorld.Main.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public string Message => "Hello from MainViewModel";
    }
}

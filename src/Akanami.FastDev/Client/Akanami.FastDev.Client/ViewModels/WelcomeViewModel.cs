using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akanami.FastDev.Client.ViewModels
{
    public class WelcomeViewModel : BindableBase
    {
        private string _title = "Hello world!";

        public string Title
        {
            get { return _title; }
            set { SetProperty<string>(ref _title, value); }
        }
    }
}

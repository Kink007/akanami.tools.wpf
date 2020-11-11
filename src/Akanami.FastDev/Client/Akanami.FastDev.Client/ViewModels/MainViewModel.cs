using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akanami.FastDev.Client.ViewModels
{
    public class MainViewModel : BindableBase
    {
        string _title = "Akanami Tools";

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }
    }
}

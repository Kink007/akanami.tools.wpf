using Akanami.FastDev.Client.Service;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akanami.FastDev.Client.ViewModels
{
    public class RightCopyViewModel : BindableBase
    {
        public RightCopyViewModel(ISoftwareInformationService softwareInformationService)
        {
            this.Company = softwareInformationService.CopyRight;
            this.Version = softwareInformationService.Version;
        }

        string _Company;

        public string Company
        {
            get { return _Company; }
            set { SetProperty<string>(ref _Company, value); }
        }

        string _Version;

        public string Version
        {
            get { return _Version; }
            set { SetProperty<string>(ref _Version, value); }
        }
    }
}

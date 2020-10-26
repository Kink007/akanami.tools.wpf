using Akanami.FastDev.Client.Service;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Akanami.FastDev.Client.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel(ISoftwareInformationService softwareInformationService)
        {
            this.Title = softwareInformationService.Name;
        }

        string _title = "快速开发工具";

        public string Title
        {
            get { return _title; }
            set { SetProperty<string>(ref _title, value); }
        }


        ICommand _OpenGitHubCommand;

        public ICommand OpenGitHubCommand
        {
            get
            {
                if (_OpenGitHubCommand == null)
                {
                    _OpenGitHubCommand = new DelegateCommand(OpenGitHub);
                }

                return _OpenGitHubCommand;
            }
        }

        protected async void OpenGitHub() 
        {
            string url = "https://github.com/Kink007/akanami.tools.wpf";

            await Task.Run(() => {
                System.Diagnostics.Process.Start("explorer.exe", url);
            });
        }
    }
}

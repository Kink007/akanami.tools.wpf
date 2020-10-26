﻿using Akanami.FastDev.Client.Service;
using Akanami.FastDev.Client.Service.Impl;
using Akanami.FastDev.Client.Views;
using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace Akanami.FastDev.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ISoftwareInformationService, SoftwareInformationServiceImpl>();   
        }
    }
}

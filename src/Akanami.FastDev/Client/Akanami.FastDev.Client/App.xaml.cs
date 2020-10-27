using Akanami.FastDev.Client.Service;
using Akanami.FastDev.Client.Service.Impl;
using Akanami.FastDev.Client.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.IO;
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

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var startupPath = Path.GetDirectoryName(typeof(App).Assembly.Location);
            var moduleDirectory = Path.Combine(startupPath, "modules");
            if (!Directory.Exists(moduleDirectory))
            {
                Directory.CreateDirectory(moduleDirectory);
            }

            return new DirectoryModuleCatalog() { ModulePath = moduleDirectory };
        }
    }
}

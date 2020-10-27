using Akanami.FastDev.Infrastructure;
using Akanami.FastDev.QuickStart.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using Unity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akanami.FastDev.QuickStart
{
    public class QuickStartModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.TopMenuRegion, typeof(ResentSoftwareView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
            //containerRegistry.RegisterForNavigation(typeof(ResentSoftwareView), ViewNames.QuickStart.ResentSoftwareView);
        }
    }
}

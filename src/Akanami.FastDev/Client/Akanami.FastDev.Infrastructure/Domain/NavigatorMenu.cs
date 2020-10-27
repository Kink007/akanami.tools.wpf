using System;
using System.Collections.Generic;
using System.Text;

namespace Akanami.FastDev.Infrastructure.Domain
{
    public class NavigatorMenu
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }

        public List<NavigatorItem> Items { get; set; }
    }
}

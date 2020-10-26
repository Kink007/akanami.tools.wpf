using System;
using System.Collections.Generic;
using System.Text;

namespace Akanami.FastDev.Client.Service
{
    public interface ISoftwareInformationService
    {
        string Name { get; }
        string CopyRight { get; }
        string Version { get; }
    }
}

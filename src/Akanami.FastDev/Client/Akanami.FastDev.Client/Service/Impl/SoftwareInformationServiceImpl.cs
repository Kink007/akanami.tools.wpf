using System;
using System.Collections.Generic;
using System.Text;

namespace Akanami.FastDev.Client.Service.Impl
{
    public class SoftwareInformationServiceImpl : ISoftwareInformationService
    {
        public string Name => "快速开发工具";

        public string CopyRight => "版权 © Akanami";

        public string Version => "版本 dev-v0.1";
    }
}

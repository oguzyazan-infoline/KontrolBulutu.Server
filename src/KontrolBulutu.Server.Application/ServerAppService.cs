﻿using System;
using System.Collections.Generic;
using System.Text;
using KontrolBulutu.Server.Localization;
using Volo.Abp.Application.Services;

namespace KontrolBulutu.Server
{
    /* Inherit your application services from this class.
     */
    public abstract class ServerAppService : ApplicationService
    {
        protected ServerAppService()
        {
            LocalizationResource = typeof(ServerResource);
        }
    }
}

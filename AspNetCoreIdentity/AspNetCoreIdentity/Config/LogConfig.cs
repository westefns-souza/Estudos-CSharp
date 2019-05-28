using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KissLog;
using KissLog.Apis.v1.Listeners;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreIdentity.Config
{
    public static class LogConfig
    {
        public static void ConfigureKissLog(IConfiguration configuration)
        {
            KissLogConfiguration.Listeners.Add(new KissLogApiListener(new KissLog.Apis.v1.Auth.Application(
                configuration["KissLog.OrganizationId"],
                configuration["KissLog.ApplicationId"])
            ));
        }
    }
}

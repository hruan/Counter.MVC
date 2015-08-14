using System;

namespace Counter.Controllers
{
    public class ApplicationConfigurationFromEnvironment : IApplicationConfiguration
    {
        public string GetApiPath()
        {
            return Environment.GetEnvironmentVariable("ApiPath");
        }
    }
}
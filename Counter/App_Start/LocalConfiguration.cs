using System;

namespace Counter
{
    public static class LocalConfiguration
    {
        public static void SetEnvironmentVariables()
        {
            Environment.SetEnvironmentVariable("ApiPath", "http://localhost:4657/api/count/apelsin");
        }
    }
}
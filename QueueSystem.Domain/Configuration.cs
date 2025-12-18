

using Microsoft.Extensions.Configuration;

namespace QueueSystem.Domain
{
    public static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../QueueSystem"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("ConnectStr");
            }
        }
    }
}

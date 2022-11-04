using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KJHCore
{
    public class AppConfigHelper
    {
        public static string GetAppConfig(string key) => ConfigurationManager.AppSettings[key];

        public static void SetAppConfig(string key, string value)
        {
            System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
            settings.Remove(key);
            settings.Add(key, value);
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
        }

        public static void AddAppConfig(string key, string value)
        {
            System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings.Add(key, value);
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
        }

        public static void RemoveAppConfig(string key)
        {
            System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
            try
            {
                settings.Remove(key);
                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
            }
            catch
            {
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApi
{
    public class ConfigFileSection : ConfigurationSection
    {
        public ConfigFileSection() { }

        [ConfigurationProperty("settings", IsDefaultCollection = false)]
        public ConfigFileCollection Settings
        {
            get
            {
                ConfigFileCollection configFileCollection =
                    (ConfigFileCollection)base["settings"];

                return configFileCollection;
            }

            set
            {
                base["settings"] = value;
            }
        }
    }
}

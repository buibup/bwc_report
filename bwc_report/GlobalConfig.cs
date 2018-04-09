using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace bwc_report
{
    public static class GlobalConfig
    {
        public static decimal MileWalkTest { get; set; }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppString(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}
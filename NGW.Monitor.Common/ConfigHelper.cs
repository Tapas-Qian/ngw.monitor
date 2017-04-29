using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGW.Monitor.Common
{
    public class ConfigHelper
    {
        /// <summary>
        /// 监控中心连接
        /// </summary>
        public static string DB_MonitorConnection
        {
           get
           {
               return ConfigurationManager.ConnectionStrings["DB_MonitorConnection"].ToString();
           }
        }

    }
}

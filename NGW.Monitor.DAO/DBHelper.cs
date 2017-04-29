using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using NGW.Monitor.Model;

namespace NGW.Monitor.DAO
{
    internal class DBHelper
    {       
        /// <summary>
        /// 获取项目连接串
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public static string GetDBConnection(string projectName)
        {
            return ConfigDao.GetProjectConfig(projectName).dbconn;
        }
    }
}

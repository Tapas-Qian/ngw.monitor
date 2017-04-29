using NGW.Monitor.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace NGW.Monitor.DAO
{
    /// <summary>
	/// 日志访问类:Logs
	/// </summary>
    public class LogsDao
    {
        /// <summary>
        /// 记录一条日志
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public bool AddLogs(CommonLogs log)
        {
           using (IDbConnection conn = new SqlConnection(DBHelper.GetDBConnection(log.ModuleConfig.ProjectConfig.project_name)))
           {
                 string query = string.Format(@"INSERT INTO {0}Logs
                                            ([log_type]
                                            ,[ip]
                                            ,[function_name]
                                            ,[variables]
                                            ,[message]
                                            ,[createtime])
                                        VALUES
                                            (@log_type
                                            ,@ip
                                            ,@function_name
                                            ,@variables
                                            ,@message
                                            ,@createtime)",log.ModuleConfig.module_name);
                return conn.Execute(query,log)>0;
           }
        }

        /// <summary>
        /// 获取全部日志
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public List<CommonLogs> GetAllLogs(CommonLogs log)
        {
            return null;
        }
    }
}

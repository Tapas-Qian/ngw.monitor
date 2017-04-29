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
   public class ConfigDao
    {
       #region ProjectConfig
       public static bool AddProjectConfig(ProjectConfig project)
       {
           using (IDbConnection monitor_conn = new SqlConnection(NGW.Monitor.Common.ConfigHelper.DB_MonitorConnection))
           {
               string query = @"INSERT INTO [dbo].[ProjectConfig]
                                                ([project_name]
                                                ,[project_des]
                                                ,[dbconn]
                                                ,[createtime]
                                                ,[updatetime])
                                            VALUES
                                                (@project_name
                                                ,@project_des
                                                ,@dbconn
                                                ,@createtime
                                                ,@updatetime)";
               return monitor_conn.Execute(query, project) > 0;
           }
       }

       /// <summary>
       /// 查询单个项目配置
       /// </summary>
       /// <param name="name"></param>
       /// <returns></returns>
       public static ProjectConfig GetProjectConfig(string name)
       {
           using (IDbConnection conn = new SqlConnection(NGW.Monitor.Common.ConfigHelper.DB_MonitorConnection))
           {
               ProjectConfig project;
               string query = @"SELECT [project_id]
                                      ,[project_name]
                                      ,[project_des]
                                      ,[dbconn]
                                      ,[createtime]
                                      ,[updatetime]
                                  FROM [dbo].[ProjectConfig] where project_name=@project_name ";
               project = conn.Query<ProjectConfig>(query, new { project_name = name }).SingleOrDefault();
               return project;              
           }
       }

       /// <summary>
       /// 查询全部项目配置
       /// </summary>
       /// <returns></returns>
       public static List<ProjectConfig> GetAllProjectConfig()
       {
           using (IDbConnection conn = new SqlConnection(NGW.Monitor.Common.ConfigHelper.DB_MonitorConnection))
           {
               List<ProjectConfig> projects;
               string query = @"SELECT [project_id]
                                      ,[project_name]
                                      ,[project_des]
                                      ,[dbconn]
                                      ,[createtime]
                                      ,[updatetime]
                                  FROM [dbo].[ProjectConfig] ";
               projects = conn.Query<ProjectConfig>(query).ToList();
               return projects;              
           }
       }
       #endregion

       #region ModuleConfig
       /// <summary>
       /// 查询单个模块配置
       /// </summary>
       /// <param name="name"></param>
       /// <returns></returns>
       public static ModuleConfig GetModuleConfig(string name)
       {
           using (IDbConnection conn = new SqlConnection(NGW.Monitor.Common.ConfigHelper.DB_MonitorConnection))
           {
               ModuleConfig module;
               string query = @"SELECT [module_id]
                                      ,[module_name]
                                      ,[project_id]
                                      ,[module_des]
                                      ,[contact_email]
                                      ,[contact_moblie]
                                      ,[createtime]
                                      ,[updatetime]
                                  FROM [dbo].[ModuleConfig] where module_name=@module_name ";
               module = conn.Query<ModuleConfig>(query, new { module_name = name }).SingleOrDefault();
               return module;
           }
       }

       /// <summary>
       /// 查询全部模块配置
       /// </summary>
       /// <param name="name"></param>
       /// <returns></returns>
       public static List<ModuleConfig> GetAllModuleConfig(ProjectConfig project)
       {
           using (IDbConnection conn = new SqlConnection(NGW.Monitor.Common.ConfigHelper.DB_MonitorConnection))
           {
               string query = @"SELECT [module_id]
                                      ,[module_name]
                                      ,[project_id]
                                      ,[module_des]
                                      ,[contact_email]
                                      ,[contact_moblie]
                                      ,[createtime]
                                      ,[updatetime]
                                  FROM [dbo].[ModuleConfig] where project_id=@project_id ";
               return conn.Query<ModuleConfig>(query, new { project_id = project.project_id }).ToList();
           }
       }

       /// <summary>
       /// 添加模块配置
       /// </summary>
       /// <param name="name"></param>
       /// <returns></returns>
       public static bool AddModuleConfig(ModuleConfig module)
       {
           int cretb_result = -1;
           using (IDbConnection conn = new SqlConnection(DBHelper.GetDBConnection(module.ProjectConfig.project_name)))
           {
               string query = string.Format(@"IF OBJECT_ID('{0}_Logs') IS NULL
                          BEGIN
                            CREATE TABLE {0}_Logs(
                            log_id           bigint            IDENTITY(1,1),
                            log_type         tinyint           NOT NULL,
                            ip               varchar(15)       NULL,
                            function_name    nvarchar(80)      NULL,
                            variables        nvarchar(800)     NULL,
                            message          nvarchar(2000)    NULL,
                            createtime       datetime          NULL);
                            SELECT OBJECT_ID('{0}_Logs');
                          END
                         ELSE
                          BEGIN SELECT OBJECT_ID('{0}_Logs') END", module.module_name);
               cretb_result = conn.Query<int>(query).SingleOrDefault();
           }
           if (cretb_result < 0) return false;

           using (IDbConnection monitor_conn = new SqlConnection(NGW.Monitor.Common.ConfigHelper.DB_MonitorConnection))
           {
               string query = @"INSERT INTO [dbo].[ModuleConfig]
                                                   ([module_name]
                                                   ,[project_id]
                                                   ,[module_des]
                                                   ,[contact_email]
                                                   ,[contact_moblie]
                                                   ,[createtime]
                                                   ,[updatetime])
                                             VALUES
                                                   (@module_name
                                                   ,@project_id
                                                   ,@module_des
                                                   ,@contact_email
                                                   ,@contact_moblie
                                                   ,@createtime
                                                   ,@updatetime) ";
               return monitor_conn.Execute(query, module) > 0;
           }
       }

       #endregion 
    }
}

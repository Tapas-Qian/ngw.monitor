using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NGW.Monitor.DAO;
using NGW.Monitor.Model;

namespace NGW.Monitor.Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddProject()
        {
            var obj = new ProjectConfig
            {
                project_name = "testproject",
                dbconn = "Data Source=192.168.2.112;Initial Catalog=DB_Monitor;User ID=sa;Password=taotao778899!;Persist Security Info=False;Max Pool Size=100",
                project_des = "测试项目",
                createtime=DateTime.Now,
                updatetime=DateTime.Now               
            };
            ConfigDao.AddProjectConfig(obj);
        }

        [TestMethod]
        public void TestAddModule()
        {
            var obj = new ModuleConfig
            {
                module_name = "testmodule",
                project_id = 0,
                contact_email = "qianjinli@niuguwang.com",
                contact_moblie = "13693304040;13693350505",
                createtime = DateTime.Now,
                updatetime = DateTime.Now,
                module_des = "测试模块",
                ProjectConfig = new ProjectConfig { project_name="testproject" }
            };
            ConfigDao.AddModuleConfig(obj);
        }
    }
}

/**
* 类 名： ModuleConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/28 11:40:47  钱金利   初版
*/
using System;
namespace NGW.Monitor.Model
{
	/// <summary>
	/// ModuleConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ModuleConfig
	{
		public ModuleConfig()
		{}
		#region Model
		private int _module_id;
		private string _module_name;
		private int _project_id;
		private string _module_des;
		private string _contact_email;
		private string _contact_moblie;
		private DateTime _createtime;
		private DateTime _updatetime;
        private ProjectConfig _projectconfig;
		/// <summary>
		/// 
		/// </summary>
		public int module_id
		{
			set{ _module_id=value;}
			get{return _module_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string module_name
		{
			set{ _module_name=value;}
			get{return _module_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int project_id
		{
			set{ _project_id=value;}
			get{return _project_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string module_des
		{
			set{ _module_des=value;}
			get{return _module_des;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contact_email
		{
			set{ _contact_email=value;}
			get{return _contact_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contact_moblie
		{
			set{ _contact_moblie=value;}
			get{return _contact_moblie;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime updatetime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}

        /// <summary>
        /// 项目配置
        /// </summary>
        public ProjectConfig ProjectConfig
        {
            set { _projectconfig = value; }
            get { return _projectconfig; }
        }
		#endregion Model

	}
}


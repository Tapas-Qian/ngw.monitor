/**
* 类 名： CommonLogs
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/28 11:40:47  钱金利   初版
*/
using System;
namespace NGW.Monitor.Model
{
	/// <summary>
	/// UserLogs:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CommonLogs
	{
        public CommonLogs()
		{}
		#region Model
		private long _log_id;
		private int _log_type;
		private string _ip;
		private string _function_name;
		private string _variables;
		private string _message;
		private DateTime _createtime;
        private ModuleConfig _moduleconfig;
		/// <summary>
		/// 
		/// </summary>
		public long log_id
		{
			set{ _log_id=value;}
			get{return _log_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int log_type
		{
			set{ _log_type=value;}
			get{return _log_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string function_name
		{
			set{ _function_name=value;}
			get{return _function_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string variables
		{
			set{ _variables=value;}
			get{return _variables;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string message
		{
			set{ _message=value;}
			get{return _message;}
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
        /// 模块配置
        /// </summary>
        public ModuleConfig ModuleConfig
        {
            set { _moduleconfig = value; }
            get { return _moduleconfig; }
        }
		#endregion Model

	}
}


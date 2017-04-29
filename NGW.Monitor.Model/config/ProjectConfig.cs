/**
* 类 名： ProjectConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/28 11:40:47  钱金利   初版
*/
using System;
namespace NGW.Monitor.Model
{
	/// <summary>
	/// ProjectConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ProjectConfig
	{
		public ProjectConfig()
		{}
		#region Model
		private int _project_id;
		private string _project_name;
		private string _project_des;
		private string _dbconn;
		private DateTime _createtime;
        private DateTime _updatetime;
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
		public string project_name
		{
			set{ _project_name=value;}
			get{return _project_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_des
		{
			set{ _project_des=value;}
			get{return _project_des;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dbconn
		{
			set{ _dbconn=value;}
			get{return _dbconn;}
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
		#endregion Model

	}
}


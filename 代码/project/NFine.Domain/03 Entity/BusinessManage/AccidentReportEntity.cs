
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueGene.Domain.Entity.BusinessManage
{
    /// <summary>
    /// AccidentReport Entity Model
    /// </summary>
    public class AccidentReportEntity : IEntity<AccidentReportEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
		
			
			/// <summary>
			/// F_Id 
			/// </summary>
			public  String  F_Id { get; set; }
		
			/// <summary>
			/// 地盤/部門 外鍵 
			/// </summary>
			public  String  F_ProjectId { get; set; }
		
			/// <summary>
			/// 事故類型【1：輕微 2：一般 3：嚴重】 
			/// </summary>
			public  String  F_AccidentType { get; set; }
		
			/// <summary>
			/// 事故發生時間 
			/// </summary>
			public  DateTime?  F_AccidentHappenedTime { get; set; }
		
			/// <summary>
			/// 報告電郵質技部備案時間  輕微事故有此項 
			/// </summary>
			public  DateTime?  F_AccidentRecordTime { get; set; }
		
			/// <summary>
			/// 呈報初步通知書日期 
			/// </summary>
			public  DateTime?  F_AccidentNoticeTime { get; set; }
		
			/// <summary>
			/// 呈報質量事故報告日期 
			/// </summary>
			public  DateTime?  F_AccidentSubmitTime { get; set; }
		
			/// <summary>
			/// 事故關閉日期 
			/// </summary>
			public  DateTime?  F_AccidentEndTime { get; set; }
		
			/// <summary>
			/// 事故簡述 100字 
			/// </summary>
			public  String  F_Description { get; set; }
		
			/// <summary>
			/// F_DeleteMark 
			/// </summary>
			public  Boolean?  F_DeleteMark { get; set; }
		
			/// <summary>
			/// F_CreatorTime 
			/// </summary>
			public  DateTime?  F_CreatorTime { get; set; }
		
			/// <summary>
			/// F_CreatorUserId 
			/// </summary>
			public  String  F_CreatorUserId { get; set; }
		
			/// <summary>
			/// F_LastModifyTime 
			/// </summary>
			public  DateTime?  F_LastModifyTime { get; set; }
		
			/// <summary>
			/// F_LastModifyUserId 
			/// </summary>
			public  String  F_LastModifyUserId { get; set; }
		
			/// <summary>
			/// F_DeleteTime 
			/// </summary>
			public  DateTime?  F_DeleteTime { get; set; }
		
			/// <summary>
			/// F_DeleteUserId 
			/// </summary>
			public  String  F_DeleteUserId { get; set; }
		
    }
}
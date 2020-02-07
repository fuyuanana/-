



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueGene.Domain.Entity.BusinessManage
{
    /// <summary>
    /// Projects Entity Model
    /// </summary>
    public class ProjectsEntity : IEntity<ProjectsEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
			
			public  String  F_Id { get; set; }
		
			public  String  F_ProjectName { get; set; }
		
			public  Boolean?  F_IsComplete { get; set; }
		
			public  Boolean?  F_DeleteMark { get; set; }
		
			public  DateTime?  F_CreatorTime { get; set; }
		
			public  String  F_CreatorUserId { get; set; }
		
			public  DateTime?  F_LastModifyTime { get; set; }
		
			public  String  F_LastModifyUserId { get; set; }
		
			public  DateTime?  F_DeleteTime { get; set; }
		
			public  String  F_DeleteUserId { get; set; }
		
			public  String  F_Description { get; set; }
		
    }
}
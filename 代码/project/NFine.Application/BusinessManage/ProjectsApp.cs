using BlueGene.Code;
using BlueGene.Domain.Entity;
using BlueGene.Domain.Entity.BusinessManage;
using BlueGene.Domain.IRepository;
using BlueGene.Domain.IRepository.BusinessManage;
using BlueGene.Repository;
using BlueGene.Repository.BusinessManage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueGene.Application.BusinessManage
{
    public class ProjectsApp
    {
		private IProjectsRepository service = new ProjectsRepository();

        public List<ProjectsEntity> GetList()
        {
            return service.IQueryable().OrderBy(t => t.F_CreatorTime).ToList();
        }
        public List<ProjectsEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<ProjectsEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_ProjectName.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public ProjectsEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(ProjectsEntity entity)
        {
            service.Delete(entity);
        }

        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }

		public void SubmitForm(ProjectsEntity entity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                service.Update(entity);
            }
            else
            {
                entity.Create();
                service.Insert(entity);
            }
        }
    }
}
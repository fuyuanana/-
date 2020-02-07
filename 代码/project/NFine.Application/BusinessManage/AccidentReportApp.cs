



using BlueGene.Code;
using BlueGene.Domain.Entity.BusinessManage;
using BlueGene.Domain.IRepository.BusinessManage;
using BlueGene.Repository.BusinessManage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueGene.Application.BusinessManage
{
    public class AccidentReportApp
    {
		private IAccidentReportRepository service = new AccidentReportRepository();

		 public List<AccidentReportEntity> GetList()
        {
            return service.IQueryable().OrderBy(t => t.F_CreatorTime).ToList();
        }

		public List<AccidentReportEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<AccidentReportEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                //expression = expression.And(t => t.F_CreatorTime.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public AccidentReportEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

		 public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }

        public void Delete(AccidentReportEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(AccidentReportEntity entity, string keyValue)
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
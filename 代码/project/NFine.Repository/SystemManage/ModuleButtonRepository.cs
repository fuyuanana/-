


 


using BlueGene.Data;
using BlueGene.Domain.Entity.SystemManage;
using BlueGene.Domain.IRepository.SystemManage;
using BlueGene.Repository.SystemManage;
using System.Collections.Generic;

namespace BlueGene.Repository.SystemManage
{
    public class ModuleButtonRepository : RepositoryBase<ModuleButtonEntity>, IModuleButtonRepository
    {
        public void SubmitCloneButton(List<ModuleButtonEntity> entitys)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                foreach (var item in entitys)
                {
                    db.Insert(item);
                }
                db.Commit();
            }
        }
    }
}

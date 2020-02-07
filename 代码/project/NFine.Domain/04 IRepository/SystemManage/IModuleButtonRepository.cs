


 


using BlueGene.Data;
using BlueGene.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace BlueGene.Domain.IRepository.SystemManage
{
    public interface IModuleButtonRepository : IRepositoryBase<ModuleButtonEntity>
    {
        void SubmitCloneButton(List<ModuleButtonEntity> entitys);
    }
}

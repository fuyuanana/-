


 


using BlueGene.Data;
using BlueGene.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace BlueGene.Domain.IRepository.SystemManage
{
    public interface IRoleRepository : IRepositoryBase<RoleEntity>
    {
        void DeleteForm(string keyValue);
        void SubmitForm(RoleEntity roleEntity, List<RoleAuthorizeEntity> roleAuthorizeEntitys, string keyValue);
    }
}

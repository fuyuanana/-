


 


using BlueGene.Data;
using BlueGene.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace BlueGene.Domain.IRepository.SystemManage
{
    public interface IItemsDetailRepository : IRepositoryBase<ItemsDetailEntity>
    {
        List<ItemsDetailEntity> GetItemList(string enCode);
    }
}

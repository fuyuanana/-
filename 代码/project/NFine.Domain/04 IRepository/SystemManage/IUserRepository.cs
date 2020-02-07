


 


using BlueGene.Data;
using BlueGene.Domain.Entity.SystemManage;

namespace BlueGene.Domain.IRepository.SystemManage
{
    public interface IUserRepository : IRepositoryBase<UserEntity>
    {
        void DeleteForm(string keyValue);
        void SubmitForm(UserEntity userEntity, UserLogOnEntity userLogOnEntity, string keyValue);
    }
}




 


using BlueGene.Data;
using BlueGene.Domain.Entity.SystemSecurity;

namespace BlueGene.Domain.IRepository.SystemSecurity
{
    public interface IDbBackupRepository : IRepositoryBase<DbBackupEntity>
    {
        void DeleteForm(string keyValue);
        void ExecuteDbBackup(DbBackupEntity dbBackupEntity);
    }
}

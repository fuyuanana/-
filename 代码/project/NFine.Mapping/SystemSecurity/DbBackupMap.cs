


 


using BlueGene.Domain.Entity.SystemSecurity;
using System.Data.Entity.ModelConfiguration;

namespace BlueGene.Mapping.SystemSecurity
{
    public class DbBackupMap : EntityTypeConfiguration<DbBackupEntity>
    {
        public DbBackupMap()
        {
            this.ToTable("Sys_DbBackup");
            this.HasKey(t => t.F_Id);
        }
    }
}

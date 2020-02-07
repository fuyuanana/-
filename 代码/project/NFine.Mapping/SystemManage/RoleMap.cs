


 


using BlueGene.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace BlueGene.Mapping.SystemManage
{
    public class RoleMap : EntityTypeConfiguration<RoleEntity>
    {
        public RoleMap()
        {
            this.ToTable("Sys_Role");
            this.HasKey(t => t.F_Id);
        }
    }
}

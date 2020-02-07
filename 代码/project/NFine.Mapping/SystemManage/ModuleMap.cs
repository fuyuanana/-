


 


using BlueGene.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace BlueGene.Mapping.SystemManage
{
    public class ModuleMap : EntityTypeConfiguration<ModuleEntity>
    {
        public ModuleMap()
        {
            this.ToTable("Sys_Module");
            this.HasKey(t => t.F_Id);
        }
    }
}

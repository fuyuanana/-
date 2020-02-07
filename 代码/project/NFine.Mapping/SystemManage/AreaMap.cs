


 


using BlueGene.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace BlueGene.Mapping.SystemManage
{
    public class AreaMap : EntityTypeConfiguration<AreaEntity>
    {
        public AreaMap()
        {
            this.ToTable("Sys_Area");
            this.HasKey(t => t.F_Id);
        }
    }
}

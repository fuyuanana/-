



using BlueGene.Domain.Entity.BusinessManage;
using BlueGene.Domain.IRepository.BusinessManage;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueGene.Mapping.BusinessManage
{
    public class ProjectsMap : EntityTypeConfiguration<ProjectsEntity>
    {
		 public ProjectsMap()
        {
            this.ToTable("MD_Projects");
            this.HasKey(t => t.F_Id);
        }
    }
}
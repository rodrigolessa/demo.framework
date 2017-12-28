using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.domain.Entities;

namespace demo.frm.infrastructure.data.UnitOfWork.EntityTypeConfigurations
{
    public class PaisTypeConfiguration : EntityTypeConfiguration<PaisView>
    {
        public PaisTypeConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Sigla)
                .HasMaxLength(2);

            this.Property(t => t.Descricao)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PaisView");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Sigla).HasColumnName("Sigla");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}

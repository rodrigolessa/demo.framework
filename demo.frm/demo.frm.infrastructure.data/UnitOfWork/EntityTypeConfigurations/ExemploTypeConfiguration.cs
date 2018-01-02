using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.Text;
using System.Threading.Tasks;
using demo.frm.domain.Entities;
using demo.frm.domain.Entities.ValueObjects;

namespace demo.frm.infrastructure.data.UnitOfWork.EntityTypeConfigurations
{
    public class ExemploTypeConfiguration : EntityTypeConfiguration<Exemplo>
    {
        public ExemploTypeConfiguration()
        {
            Property(x => x.CPF.Codigo)
                .HasColumnName("CPF")
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("IX_CPF", 1) { IsUnique = true }));

            Property(x => x.Login)
               .HasMaxLength(Exemplo.LoginMaxLength)
               .HasColumnAnnotation(IndexAnnotation.AnnotationName,
               new IndexAnnotation(new IndexAttribute("IX_Login", 2) { IsUnique = true }));

            Property(x => x.Email.Endereco)
                .HasColumnName("Email")
                .HasMaxLength(Email.EnderecoMaxLength)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
               new IndexAnnotation(new IndexAttribute("IX_Email", 3) { IsUnique = true }));

            Property(x => x.Endereco.Bairro)
                .HasColumnName("Bairro")
                .HasMaxLength(Endereco.BairroMaxLength);

            Property(x => x.Endereco.Cidade)
                .HasColumnName("Cidade")
                .HasMaxLength(Endereco.CidadeMaxLength);

            Property(x => x.Endereco.Complemento)
                .HasColumnName("Complemento")
                .HasMaxLength(Endereco.ComplementoMaxLength);

            Property(x => x.Endereco.Logradouro)
                .HasColumnName("Logradouro")
                .HasMaxLength(Endereco.LogradouroMaxLength);

            Property(x => x.Endereco.Numero)
                .HasColumnName("Numero")
                .HasMaxLength(Endereco.NumeroMaxLength);

            Property(x => x.Endereco.Uf)
                .HasColumnName("Uf");

            Property(x => x.Endereco.Cep.CepCod)
                .HasColumnName("Cep");
        }
    }
}
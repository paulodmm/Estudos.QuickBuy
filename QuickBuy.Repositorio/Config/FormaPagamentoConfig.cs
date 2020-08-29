using Estudos.QuickBuy.Dominio.Entidades;
using Estudos.QuickBuy.Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfig : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

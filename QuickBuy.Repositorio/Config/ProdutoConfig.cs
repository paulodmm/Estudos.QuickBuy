using Estudos.QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome)
                .IsRequired();
            builder.Property(u => u.Descricao)
                .IsRequired();
            builder.Property(u => u.Preco)
                .IsRequired();
        }
    }
}

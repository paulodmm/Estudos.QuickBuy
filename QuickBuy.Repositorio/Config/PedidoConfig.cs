using Estudos.QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.DataPedido)
                .IsRequired();

            builder.Property(u => u.DataPrevisaoEntrega)
                .IsRequired();
            builder.Property(u => u.CEP)
                .IsRequired();
            builder.Property(u => u.Estado)
                .IsRequired();
            builder.Property(u => u.Cidade)
                .IsRequired();
            builder.Property(u => u.EnderecoCompleto)
                .IsRequired();
            builder.Property(u => u.NumeroEndereco)
                .IsRequired();
            builder.Property(u => u.FormaPagamentoId)
                .IsRequired();


            builder.HasOne(d => d.UsuarioPedido);
         
        }
    }
}

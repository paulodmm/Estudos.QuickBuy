using Estudos.QuickBuy.Dominio.Entidades;
using Estudos.QuickBuy.Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContexto()
        {

        }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfig());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { Id = 1, Nome = "Boleto", Descricao = "Tipo Boleto" }
                , new FormaPagamento() { Id = 2, Nome = "CartaoCredito", Descricao = "Tipo cartão de crédito" }
                , new FormaPagamento() { Id = 3, Nome = "Deposito", Descricao = "Tipo depósito" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}

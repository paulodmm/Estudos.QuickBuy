using System;
using System.Collections.Generic;
using System.Text;
using Estudos.QuickBuy.Dominio.Enumerados;

namespace Estudos.QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoFormaPagamentoEnum Tipo
        {
            get { return (TipoFormaPagamentoEnum)Id; }
        }

        public bool Eh(TipoFormaPagamentoEnum tipo)
        {
            return this.Tipo == tipo;
        }

        public bool EhBoleto
        {
            get
            {
                return this.Tipo == TipoFormaPagamentoEnum.Boleto;
            }
        }

        public bool EhCartaoCredito
        {
            get
            {
                return this.Tipo == TipoFormaPagamentoEnum.CartaoCredito;
            }
        }

        public bool EhDeposito
        {
            get
            {
                return this.Tipo == TipoFormaPagamentoEnum.Deposito;
            }
        }

        public bool EhNaoDefinido
        {
            get
            {
                return this.Tipo == TipoFormaPagamentoEnum.NaoDefinido;
            }
        }
    }
}

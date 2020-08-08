using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estudos.QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        protected List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagem()
        {
            this._mensagensValidacao.Clear();
        }

        protected void AdiconarCritica(string mensagem)
        {
            this._mensagensValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !this.MensagemValidacao.Any(); }
        }
    }
}

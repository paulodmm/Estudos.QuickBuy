﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos.QuickBuy.Dominio.Contratos
{
    public interface IBaseRespositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}

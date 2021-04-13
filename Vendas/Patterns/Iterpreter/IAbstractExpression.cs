using System;
using System.Collections.Generic;
using System.Text;
using Vendas.Models;

namespace Vendas.Interfaces
{
    public interface IAbstractExpression
    {
        void Evaluate(Venda context);
    }
}

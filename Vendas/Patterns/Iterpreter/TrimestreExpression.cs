using System;
using System.Collections.Generic;
using System.Text;
using Vendas.Interfaces;
using Vendas.Models;

namespace Vendas.Expressions
{
    public class TrimestreExpression : IAbstractExpression
    {
        public void Evaluate(Venda context)
        {
            context.Trimestre = context.DataVenda.Year.ToString() + "-";
			switch (context.DataVenda.Month)
			{

				case 1:
				case 2:
				case 3:
					context.Trimestre += "1";
					break;
				case 4:
				case 5:
				case 6:
					context.Trimestre += "2";
					break;
				case 7:
				case 8:
				case 9:
					context.Trimestre += "3";
					break;
				case 10:
				case 11:
				case 12:
					context.Trimestre += "4";
					break;
				default:
					break;
			}

		}
    }
}

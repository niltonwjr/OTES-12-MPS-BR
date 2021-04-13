using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas.Models
{
	public class Venda
	{
		public Guid Id { get; set; }
		public long Numero { get; set; }
		public Vendedor Vendedor { get; set; }
		public DateTime DataVenda { get; set; }
		public string Trimestre { get; set; }
		public decimal ValorVenda { get; set; }

		public Venda(long numero, Vendedor vendedor, decimal valor, DateTime data) 
		{
			Id = Guid.NewGuid();
			Vendedor = vendedor;
			ValorVenda = valor;
			DataVenda = data;
			Numero = numero;

		}

	}
}

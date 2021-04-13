using System;
using System.Collections.Generic;
using System.Text;
using Vendas.Patterns.FlyWeight;

namespace Vendas.Models
{
	public class Vendedor
	{
		public Guid Id { get; set; }
		public int Numero { get; set; }
		public string Nome { get; set; }
		public Regiao Regiao { get; set; }
		public decimal Cota { get; set; }

		public Vendedor(string nome, int numero, Regiao regiao, decimal cota)
		{
			Id = Guid.NewGuid();
			Nome = nome;
			Numero = numero;
			Regiao =  regiao;
			Cota = cota;
		}

	
	}

}

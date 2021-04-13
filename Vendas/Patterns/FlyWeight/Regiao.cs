using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas.Patterns.FlyWeight
{
	[Serializable]
	public abstract class Regiao
	{
		public string Nome { get; set; }

		public int Numero { get; set; }
	}
}

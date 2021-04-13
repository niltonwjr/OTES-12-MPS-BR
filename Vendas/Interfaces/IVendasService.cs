using Vendas.Models;
using System;
using System.Collections.Generic;

namespace Vendas.Interfaces
{
	public interface IVendasService
	{
		List<Venda> GetAll();
	}
}

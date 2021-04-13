using System;
using System.Collections.Generic;
using System.Linq;
using Vendas.Models;
using Vendas.Patterns.FlyWeight;
using Vendas.Patterns.FlyWeight.Regioes;
using Vendas.Expressions;
using Vendas.Interfaces;

namespace Vendas.Services
{
	public class VendasService : IVendasService
	{
		private List<Venda> _vendas = new List<Venda>();
		private RegiaoFactory _regioesFactory = new RegiaoFactory();
		public VendasService()
		{
			_vendas.Clear();
			_vendas.Add(new Venda(1, new Vendedor("Sandra", 1, _regioesFactory.GetRegiao((int)Regioes.Oeste), 275000), 2830000, DateTime.Parse("2020-01-01")));
			_vendas.Add(new Venda(2, new Vendedor("Cirstóvão", 2, _regioesFactory.GetRegiao((int)Regioes.Norte), 350000), 297231, DateTime.Parse("2020-02-01")));
			_vendas.Add(new Venda(3, new Vendedor("Marcelo", 3, _regioesFactory.GetRegiao((int)Regioes.Oeste), 312500), (decimal)362304.50, DateTime.Parse("2020-03-01")));

		}

		public List<Venda> GetAll()
		{

			var interpreter = new TrimestreExpression();
			foreach (var venda in _vendas)
			{
				interpreter.Evaluate(venda);
			}

			return _vendas;
		}
	}
}

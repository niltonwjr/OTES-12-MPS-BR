using Projetos.Interfaces;
using Projetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projetos.Services
{
	public class ProjetosService : IProjetosService
	{
		private List<Projeto> _projetos = new List<Projeto>();
		public ProjetosService()
		{
			_projetos = new List<Projeto>();

		}

		public List<Projeto> GetAll()
		{

			return _projetos;
		}

		public long CadastrarProjeto(Projeto projeto)
		{
			if (projeto == null)
				throw new ApplicationException("Necessário informar os dados do projeto");

			if (String.IsNullOrEmpty(projeto.Identificador))
				throw new ApplicationException("Necessário informar o identificador do projeto");

			if (String.IsNullOrEmpty(projeto.Descricao))
				throw new ApplicationException("Necessário informar o descrição do projeto");

			if (projeto.Orçamento <= 0)
				throw new ApplicationException("Necessário informar o valor orçado do projeto");

			if (projeto.DataPrevistaInicio.Date < DateTime.Now.Date)
				throw new ApplicationException("Data prevista do início não pode ser menor que a data atual");


			if (projeto.DataPrevistaFim.Date < projeto.DataPrevistaInicio.Date)
				throw new ApplicationException("Data prevista do início não pode ser menor que a data atual");

			if (_projetos.Any(x => x.Identificador.ToUpper().Trim() == projeto.Identificador.ToUpper().Trim()))
				throw new ApplicationException("Já existe outro projeto cadastrado com o mesmo identificador.");


			projeto.Id = Guid.NewGuid();
			projeto.Numero = _projetos.Count + 1;


			_projetos.Add(projeto);


			return projeto.Numero;
		}

		public long AdicionarRequisitos(long numeroProjeto, List<Requisitos> requisitos)
		{
			throw new NotImplementedException();
		}


		private Projeto GetObjRecolhimento(long numeroProjeto)
		{
			var projeto = _projetos.FirstOrDefault(h => h.Numero == numeroProjeto);

			if (projeto == null)
				throw new ApplicationException("Projeto nao encontrado");

			return projeto;
		}
	}
}

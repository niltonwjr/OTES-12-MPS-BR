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

		public long AdicionarRequisitos(long numeroProjeto, List<Requisitos> requisitos)
		{
			throw new NotImplementedException();
		}

		public long CadastrarProjeto(Projeto projeto)
		{
			if (projeto == null)
				throw new ApplicationException("Necessário informar os dados do projeto");

			if (endereco.Rua == null)
				throw new ApplicationException("Necessário informar a rua");

			if (endereco.Numero == null)
				throw new ApplicationException("Necessário informar o número");

			if (endereco.Bairro == null)
				throw new ApplicationException("Necessário informar o bairro");

			if (string.IsNullOrEmpty(descricaoDosMateriais))
				throw new ApplicationException("Necessário informar a descricação dos materiais");


			var cadastroEntulho = new Projeto()
			{

				Id = Guid.NewGuid(),
				NumeroAtendimento = _listaEntulhos.Count + 1,
				Endereco = endereco,
				DescricaoMateriais = descricaoDosMateriais,
				DataInclusao = DateTime.Now,
				DataPrevisaoAtendimento = DateTime.Now.AddDays(3),
				Situacao = SituacaoRecolhimento.Novo,

			};

			_listaEntulhos.Add(cadastroEntulho);

			Console.WriteLine("Lista de entulhos cadastrados:" + _listaEntulhos.Count);

			return _listaEntulhos.Count;

			public long EncerrarProjeto(long numeroProjeto)
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

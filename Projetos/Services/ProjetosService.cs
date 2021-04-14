using Projetos.Interfaces;
using Projetos.Models;
using System;
using System.Collections.Generic;

namespace Projetos.Services
{
	public class ProjetosService : IProjetosService
	{
		private List<Projeto> _projetos = new List<Projeto>();
		public ProjetosService()
		{
			_projetos.Clear();
			

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
			throw new NotImplementedException();
		}

		public long EncerrarProjeto(long numeroProjeto)
		{
			throw new NotImplementedException();
		}
	}
}

using Projetos.Interfaces;
using Projetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projetos.Services
{
	public class GerenciaProjetosService : IGerenciaProjetosService
	{
		private List<GerenciaProjeto> _projetos = new List<GerenciaProjeto>();
		public GerenciaProjetosService()
		{
			_projetos = new List<GerenciaProjeto>();
		}

		public List<GerenciaProjeto> GetAll()
		{

			return _projetos;
		}

		public void CadastrarProjeto(string identificadorProjeto)
		{
			if (string.IsNullOrEmpty(identificadorProjeto))
				throw new ApplicationException("Necessário informar o identificador");

			if (_projetos.Any(x => x.IdentificadorProjeto.ToUpper().Trim() == identificadorProjeto.ToUpper().Trim()))
				throw new ApplicationException("Projeto ja cadastrado.");


			_projetos.Add(new GerenciaProjeto(_projetos.Count + 1, identificadorProjeto));

		}

		public void AdicionarEvidenciaGPR(string identificadorProjeto, List<EvidenciasGPR> evidencias)
		{
			var projeto = GetProjeto(identificadorProjeto);

			projeto.EvidenciasGPR.AddRange(evidencias);
		}

		public void AdicionarEvidenciaREQ(string identificadorProjeto, List<EvidenciasREQ> evidencias)
		{
			var projeto = GetProjeto(identificadorProjeto);

			projeto.EvidenciasREQ.AddRange(evidencias);
		}

		public void AdicionarEvidenciaCapacidade(string identificadorProjeto, List<EvidenciasCapacidade> evidencias)
		{
			var projeto = GetProjeto(identificadorProjeto);

			projeto.EvidenciasCapacidade.AddRange(evidencias);
		}



		private GerenciaProjeto GetProjeto(string identificadorProjeto)
		{
			var projeto = _projetos.FirstOrDefault(h => h.IdentificadorProjeto.ToUpper().Trim() == identificadorProjeto.ToUpper().Trim());

			if (projeto == null)
				throw new ApplicationException("Projeto nao encontrado");

			return projeto;
		}
	}
}

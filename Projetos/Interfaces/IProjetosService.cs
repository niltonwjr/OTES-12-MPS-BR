using System.Collections.Generic;
using Projetos.Models;

namespace Projetos.Interfaces
{
	public interface IProjetosService
	{
		List<Projeto> GetAll();
		long CadastrarProjeto(Projeto projeto);
		void AdicionarRequisitos(long numeroProjeto, List<Requisitos> requisitos);

	}
}

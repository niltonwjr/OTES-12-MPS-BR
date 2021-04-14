using System.Collections.Generic;
using Projetos.Models;

namespace Projetos.Interfaces
{
	public interface IProjetosService
	{
		List<Projeto> GetAll();
		long CadastrarProjeto(Projeto projeto);
		long AdicionarRequisitos(long numeroProjeto, List<Requisitos> requisitos);
		long EncerrarProjeto(long numeroProjeto);

	}
}

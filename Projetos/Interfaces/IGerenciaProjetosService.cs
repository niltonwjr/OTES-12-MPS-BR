using System.Collections.Generic;
using Projetos.Models;

namespace Projetos.Interfaces
{
	public interface IGerenciaProjetosService
	{
		List<GerenciaProjeto> GetAll();
		long CadastrarProjeto(string identificadorProjeto);
		void AdicionarEvidenciaGPR(long numeroProjeto, List<EvidenciasGPR> evidencias);
		void AdicionarEvidenciaREQ(long numeroProjeto, List<EvidenciasREQ> evidencias);

	}
}

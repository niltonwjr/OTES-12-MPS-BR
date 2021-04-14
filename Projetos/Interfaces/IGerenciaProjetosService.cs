using System.Collections.Generic;
using Projetos.Models;

namespace Projetos.Interfaces
{
	public interface IGerenciaProjetosService
	{
		List<GerenciaProjeto> GetAll();
		void CadastrarProjeto(string identificadorProjeto);
		void AdicionarEvidenciaGPR(string identificadorProjeto, List<EvidenciasGPR> evidencias);
		void AdicionarEvidenciaREQ(string identificadorProjeto, List<EvidenciasREQ> evidencias);
		void AdicionarEvidenciaCapacidade(string identificadorProjeto, List<EvidenciasCapacidade> evidencias);

	}
}

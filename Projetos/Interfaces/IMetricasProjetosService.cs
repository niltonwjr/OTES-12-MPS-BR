using System.Collections.Generic;
using Projetos.Models;

namespace Projetos.Interfaces
{
	public interface IMetricasProjetosService
	{

		double CalcularSMI(double modVersAtual, double modVersAtualAlter, double modVersAtualAcrescent, double modVersAntExcl); 

	}
}

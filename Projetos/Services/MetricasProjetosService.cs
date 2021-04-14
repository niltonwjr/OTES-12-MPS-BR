using Projetos.Interfaces;
using Projetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projetos.Services
{
	public class MetricasProjetosService : IMetricasProjetosService
	{
		public MetricasProjetosService()
		{
		}

		public double CalcularSMI(double modVersAtual, double modVersAtualAlter, double modVersAtualAcrescent, double modVersAntExcl)
		{
			return (modVersAtual - (modVersAtualAlter + modVersAtualAcrescent + modVersAtualAcrescent)) / modVersAtual;
		}
	}
}

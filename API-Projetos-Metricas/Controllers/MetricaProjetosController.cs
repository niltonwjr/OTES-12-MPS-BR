using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projetos.Interfaces;
using Projetos.Models;
using Projetos.Models.Api_Messaging.Projetos;
using System;
using System.Collections.Generic;

namespace API_Projetos_Gerencia.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[Authorize(Roles = "manager")]
	public class MetricaProjetosController : ControllerBase
	{


		private readonly IMetricasProjetosService _metricasProjetosService;

		public MetricaProjetosController(IMetricasProjetosService metricasService)
		{
			_metricasProjetosService = metricasService;
		}

		[HttpPost("CalcularSMI")]
		public ActionResult<double> Cadastrar(int modVersAtual, int modVersAtualAlter, int modVersAtualAcrescent, int modVersAntExcl)
		{
			try
			{
				return _metricasProjetosService.CalcularSMI(modVersAtual, modVersAtualAlter, modVersAtualAcrescent, modVersAntExcl);

			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}



	}
}

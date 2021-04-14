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
	public class GerenciaProjetosController : ControllerBase
	{


		private readonly IGerenciaProjetosService _gerenciaProjetosService;

		public GerenciaProjetosController(IGerenciaProjetosService projetosService)
		{
			_gerenciaProjetosService = projetosService;
		}

		[HttpGet]
		public List<GerenciaProjeto> GetAll()
		{
			return _gerenciaProjetosService.GetAll();
		}

		[HttpPost("Cadastrar")]
		public ActionResult Cadastrar([FromQuery] string identificadorProjeto)
		{
			try
			{
				 _gerenciaProjetosService.CadastrarProjeto(identificadorProjeto);

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}


		[HttpPost("EvidenciasGPR")]
		public ActionResult EvidenciasGPR(string identificadorProjeto, List<EvidenciasGPR> evidenciasGPR)
		{

			try
			{
				_gerenciaProjetosService.AdicionarEvidenciaGPR(identificadorProjeto, evidenciasGPR);

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost("EvidenciasREQ")]
		public ActionResult AdicionarRequisitos(string identificadorProjeto, List<EvidenciasREQ> evidenciasREQ)
		{

			try
			{
				_gerenciaProjetosService.AdicionarEvidenciaREQ(identificadorProjeto, evidenciasREQ);

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost("EvidenciasCapacidade")]
		public ActionResult AdicionarCapacidade(string identificadorProjeto, List<EvidenciasCapacidade> evidenciasCapacidade)
		{

			try
			{
				_gerenciaProjetosService.AdicionarEvidenciaCapacidade(identificadorProjeto, evidenciasCapacidade);

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}

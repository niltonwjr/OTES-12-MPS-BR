using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projetos.Interfaces;
using Projetos.Models;
using Projetos.Models.Api_Messaging.Projetos;
using System;
using System.Collections.Generic;

namespace API_Projetos.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[Authorize(Roles = "manager")]
	public class ProjetosController : ControllerBase
	{


		private readonly IProjetosService _projetosService;

		public ProjetosController(IProjetosService projetosService)
		{
			_projetosService = projetosService;
		}

		[HttpGet]
		public List<Projeto> GetAll()
		{
			return _projetosService.GetAll();
		}

		[HttpPost("Cadastrar")]
		public ActionResult Cadastrar([FromQuery] CadastrarProjetoRequest cadastroRequest)
		{
			try
			{
				var numeroProjeto = _projetosService.CadastrarProjeto(new Projeto()
				{
					Identificador = cadastroRequest.Identificador,
					Descricao = cadastroRequest.Descricao,
					DataPrevistaInicio = cadastroRequest.DataPrevistaInicio,
					DataPrevistaFim = cadastroRequest.DataPrevistaFim,
					Orçamento = cadastroRequest.Orçamento
				});

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}


		[HttpPost("AdicionarRequisitos")]
		public ActionResult AdicionarRequisitos(string identificadoreProjeto, List<Requisitos> requisitos)
		{

			try
			{
				_projetosService.AdicionarRequisitos(identificadoreProjeto, requisitos);

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}

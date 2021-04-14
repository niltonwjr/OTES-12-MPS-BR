using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projetos.Interfaces;
using Projetos.Models;
using System.Collections.Generic;

namespace API_Projetos.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[Authorize(Roles = "manager")]
	public class ProjetosController : ControllerBase
	{


		private readonly IProjetosService _projetosService;

		public ProjetosController(IProjetosService projetosService )
		{
			_projetosService = projetosService;
		}

		[HttpGet]
		public List<Projeto> GetAll()
		{
			return _projetosService.GetAll();
		}
	}
}

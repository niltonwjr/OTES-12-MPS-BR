using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vendas.Interfaces;
using Vendas.Models;

namespace API_Vendas.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[Authorize(Roles = "manager")]
	public class VendasController : ControllerBase
	{


		private readonly IVendasService _vendasService;

		public VendasController(IVendasService vendasService )
		{
			_vendasService = vendasService;
		}

		[HttpGet]
		public List<Venda> GetAll()
		{
			return _vendasService.GetAll();
		}
	}
}

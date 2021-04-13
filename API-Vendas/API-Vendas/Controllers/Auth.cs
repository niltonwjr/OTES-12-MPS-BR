using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vendas.Interfaces;
using Vendas.Models.Messaging;
using Vendas.Services;

namespace API_Vendas.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AuthController : ControllerBase
	{
		private readonly IUsuariosService _usuariosService;

		public AuthController(IUsuariosService usuariosService)
		{

			_usuariosService = usuariosService;
		}

		[HttpPost]
		[Route("login")]
		[AllowAnonymous]
		public async Task<ActionResult<dynamic>> Authenticate([FromBody] LoginRequest model)
		{
			try
			{
				// Recupera o usuário
				var user = _usuariosService.Login(model.Email, model.Senha);

				// Gera o Token
				var token = TokenService.GenerateToken(user);

				// Retorna os dados
				return new
				{
					userEmail = user.Email,
					token = token
				};

			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}

		[HttpPost]
		[Route("forgot")]
		[AllowAnonymous]
		public async Task<ActionResult<dynamic>> EsqueciMinhaSenha([FromBody] EsqueciASenhaRequest request)
		{
			try
			{
				// Recupera o usuário
				var resetToken =_usuariosService.EsqueciMinhaSenha(request.Email);
								
				///return new
				///{
				///	userEmail = request.Email,
				///	resetToken = resetToken
				///};

				return Ok($"Token para resetar a senha enviado ao email {request.Email}");

			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}

		[HttpPost]
		[Route("reset")]
		[AllowAnonymous]
		public async Task<ActionResult<dynamic>> AlterarASenha([FromBody] AlterarSenhaRequest request)
		{
			try
			{
				// Recupera o usuário
				_usuariosService.AlterarSenha(request.Email, request.ResetToken, request.NovaSenha);

				return Ok("Senha alterada com sucesso");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}

	}
}

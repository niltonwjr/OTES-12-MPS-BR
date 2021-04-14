using Projetos.Interfaces;
using Projetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projetos.Services
{
	public class UsuariosService : IUsuariosService
	{
		private List<Usuario> _usuarios = new List<Usuario>();


		public UsuariosService()
		{
			_usuarios.Add(new Usuario { Id = 1, Email = "nilton.wjr@gmail.com", Senha = "teste", Role = "manager" });
			_usuarios.Add(new Usuario { Id = 2, Email = "teste@teste", Senha = "", Role = "manager" });

		}
		public Usuario Login(string email, string senha)
		{

			var usuario = GetUser(email);

			if (usuario.Senha != senha)
				throw new Exception("Senha inválida");

			return usuario;
		}

		public Guid EsqueciMinhaSenha(string email)
		{
			var usuario = GetUser(email);

			usuario.ResetToken = Guid.NewGuid();
			

			//TODO: Servico para enviar reset token por email;

			return usuario.ResetToken.Value;
		}

		public void AlterarSenha(string email, Guid resetToken, string novaSenha)
		{
			Usuario usuario = GetUser(email);

			if (usuario.ResetToken != resetToken)
				throw new Exception("Token para alterar a senha inválido");

			usuario.Senha = novaSenha;
		}

		private Usuario GetUser(string email)
		{
			var usuario = _usuarios.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();

			if (usuario == null)
				throw new Exception("Usuario não localizado");

			return usuario;
		}
	}
}

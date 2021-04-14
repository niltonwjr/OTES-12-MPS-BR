using Projetos.Models;
using System;


namespace Projetos.Interfaces
{
	public interface IUsuariosService
	{
		Usuario Login(string email, string senha);

		Guid EsqueciMinhaSenha(string email);

		void AlterarSenha(string email, Guid resetToken, string novaSenha);
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using Vendas.Models;

namespace Vendas.Interfaces
{
	public interface IUsuariosService
	{
		Usuario Login(string email, string senha);

		Guid EsqueciMinhaSenha(string email);

		void AlterarSenha(string email, Guid resetToken, string novaSenha);
	}
}

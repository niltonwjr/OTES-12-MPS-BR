using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas.Models.Messaging
{
	public class AlterarSenhaRequest
	{
		public string Email { get; set; }

		public Guid ResetToken { get; set; }

		public string NovaSenha { get; set; }

	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Projetos.Models
{
	public class Usuario
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string Role { get; set; }
		public Guid? ResetToken  { get; set; }
	}
}

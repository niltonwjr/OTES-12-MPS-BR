using System;
using System.Collections.Generic;
using System.Text;

namespace Projetos.Models.Api_Messaging.Projetos
{
	public class CadastrarProjetoRequest
	{
		public string Identificador { get; set; }
		public string Descricao { get; set; }
		public DateTime DataPrevistaInicio { get; set; }
		public DateTime DataPrevistaFim { get; set; }
		public decimal Orçamento { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Projetos.Models
{
	public class Projeto
	{
		public Guid Id { get; set; }
		public long Numero { get; set; }
		public string Identificador { get; set; }
		public string Descricao { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime DataPrevistaInicio { get; set; }
		public DateTime DataPrevistaFim { get; set; }
		public decimal Orçamento { get; set; }
		public List<Requisitos> Requisitos { get; set; }

		public Projeto() 
		{
			Requisitos = new List<Requisitos>();
		}

	}
}

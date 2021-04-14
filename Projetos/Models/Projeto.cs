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
		public DateTime DataInicio { get; set; }
		public List<Requisitos> Requisitos { get; set; }
		public DateTime DataPrevistaFim { get; set; }
		public decimal Orçamento { get; set; }


		public Projeto(long numero, decimal valorOrçamento, DateTime dataInicio, string identificador,  string descricao, List<Requisitos> requisitos) 
		{
			Requisitos = new List<Requisitos>();
			Id = Guid.NewGuid();
			Numero = numero;
			Orçamento = valorOrçamento;
			Identificador = identificador;
			Descricao = descricao;
			DataInicio = dataInicio;

			if (string.IsNullOrEmpty(identificador))
				throw new ArgumentNullException($"Necessário informar: {nameof(identificador)}");

			if (requisitos != null)
				Requisitos = requisitos;
		}

	}
}

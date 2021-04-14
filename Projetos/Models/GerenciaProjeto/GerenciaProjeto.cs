using System;
using System.Collections.Generic;
using System.Text;

namespace Projetos.Models
{
	public class GerenciaProjeto
	{
		public Guid Id { get; set; }
		public long Numero { get; set; }
		public string IdentificadorProjeto { get; set; }

		public List<EvidenciasGPR> EvidenciasGPR { get; set; }

		public List<EvidenciasREQ> EvidenciasREQ { get; set; }


		public List<EvidenciasCapacidade> EvidenciasCapacidade { get; set; }





		GerenciaProjeto(long numero, string identificadorProjeto)
		{
			Numero = numero;

			if (string.IsNullOrEmpty(identificadorProjeto))
				throw new ArgumentNullException("Necessário informar o identificador do projeto");
			else
				IdentificadorProjeto = identificadorProjeto;

		}

	}
}

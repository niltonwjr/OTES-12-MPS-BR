using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Projetos.Models
{
	public enum EnumCapacidade
	{
		[Description("O processo produz os resultados definidos.")]
		Resultados = 1,
		[Description("A execução do processo é planejada e monitorada.")]
		Execucao_planejada = 2,
		[Description("As pessoas estão preparadas para executar suas responsabilidades no processo.")]
		Pessoas_Prepadas = 3
	}
}

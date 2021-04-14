using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Projetos.Models
{
	public enum EnumGPR
	{
		[Description("O escopo do trabalho para o projeto é estabelecido, mantido atualizado e utilizado.")]
		GPR_1 = 1,
		[Description("O orçamento e o cronograma do projeto, incluindo a definição de marcos, são estabelecidos e mantidos atualizados.")]
		GPR_5 = 5,
		[Description("Os recursos humanos para o projeto são planejados considerando as habilidades e os conhecimentos necessários para executá-lo.")]
		GPR_6 = 6,
		[Description("A estratégia de transição para operação e suporte do produto, incluindo as tarefas e o cronograma, é planejada.")]
		GPR_8 = 8,
		[Description("O envolvimento das partes interessadas no projeto é planejado.")]
		GPR_9 = 9
	}
}

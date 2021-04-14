using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Projetos.Models
{
	public enum EnumREQ
	{
		[Description(" As necessidades, expectativas e restrições das partes interessadas, tanto em relação ao produto quanto a suas interfaces, são identificadas.")]
		REQ_1 = 1,
		[Description("O compromisso da equipe técnica com a implementação dos requisitos é obtido.")]
		REQ_5 = 5,
		[Description("A rastreabilidade bidirecional entre requisitos, atividades e produtos de trabalho do projeto é estabelecida e mantida.")]
		REQ_6 = 6,
		[Description("Os planos, atividades e produtos de trabalho relacionados são revisados visando identificar e tratar inconsistência em relação aos requisitos.")]
		REQ_7 = 7
	}
}

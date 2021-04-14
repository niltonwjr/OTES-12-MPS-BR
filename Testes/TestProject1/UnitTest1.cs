using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projetos.Services;

namespace TestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var metricasService = new MetricasProjetosService();


			var smi = metricasService.CalcularSMI(10, 0, 0, 0);

			Assert.AreEqual(1, smi);
		}
	}
}

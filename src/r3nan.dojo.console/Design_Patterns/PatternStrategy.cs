using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r3nan.dojo.console.Design_Patterns
{
	public class PatternStrategy
	{
	}
	public class CustoVeiculo
	{
		double ImpostoGoverno { get;init; }
		double ImpostoDistribuidora { get; init; }
		public decimal ValorTotalVeiculo { get; init; }

		public CustoVeiculo(Car carro)
		{
			if (carro.Price <= 28000.00M)
			{
				ImpostoGoverno = 0;
				ImpostoDistribuidora = 0.05;
				ValorTotalVeiculo = carro.Price + (carro.Price * (decimal) ImpostoDistribuidora);
			}
			if (carro.Price > 28001.00M && carro.Price < 45000.00M)
			{
				ImpostoGoverno = 0.15;
				ImpostoDistribuidora = 0.10;
				ValorTotalVeiculo = carro.Price + (carro.Price * (decimal)ImpostoGoverno);
				ValorTotalVeiculo += carro.Price * (decimal)ImpostoDistribuidora;
			}
			if (carro.Price > 45000.00M)
			{
				ImpostoGoverno = 0.2;
				ImpostoDistribuidora = 0.15;
				ValorTotalVeiculo = carro.Price + (carro.Price * (decimal)ImpostoGoverno);
				ValorTotalVeiculo += carro.Price * (decimal)ImpostoDistribuidora;
			}
		}
	}
}

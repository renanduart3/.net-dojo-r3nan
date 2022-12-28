using Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace r3nan.dojo.console.Algoritmos
{
	internal sealed class Algoritmo
	{
		Car[] _carsList = new Car[]
			{
				new Car() { Name = "Viper", Price = 1000000 },
				new Car() { Name = "Viper", Price = 12000000 },
				new Car() { Name = "Jipe", Price = 46000 },
				new Car() { Name = "Jipe", Price = 40 },
				new Car() { Name = "Brasilia", Price = 16000 },
				new Car() { Name = "Smart", Price = 400 },
				new Car() { Name = "Fusca", Price = 17000 },
				new Car() { Name = "Fusca2", Price = 1720 }
			};

		public void ListaSoma(int[] arrayNumeros)
		{
			int soma = 0;
			for (int i = 0; i < arrayNumeros.Length; i++)
			{
				soma += arrayNumeros[i];
			}
			Console.WriteLine(soma);
		}
		public void AcharOMenor()
		{


			int menorValor = 0;

			for (int i = 0; i < _carsList.Length; i++)
			{
				if (_carsList[i].Price < _carsList[menorValor].Price)
				{
					menorValor = i;
				}
			}



			Console.WriteLine("menor valor encontrato: " + _carsList[menorValor].Name + " \nPreço: " + _carsList[menorValor].Price);
		}
		public void SelectionSort()
		{

			for (int i = 0; i < _carsList.Length; i++)
			{
				for (int j = i + 1; j < _carsList.Length; j++)
				{
					if (_carsList[j].Price < _carsList[i].Price)
					{
						var aux = _carsList[i];
						_carsList[i] = _carsList[j];
						_carsList[j] = aux;
					}
				}
			}
			Imprimir();
		}
		private void Imprimir()
		{
			Console.WriteLine("Lista ordenada:");
			foreach (var item in _carsList)
			{
				Console.WriteLine($" {item.Name} - Preço: {item.Price}");
			}
		}
		public void InsertionSort()
		{
			Console.WriteLine("Antesde ordenar:");

			foreach (var item in _carsList)
			{
				Console.WriteLine($" {item.Name} - {item.Price} ");
			}

			for (int i = 1; i < _carsList.Length; i++)
			{
				int atual = i;
				while (atual > 0 && _carsList[atual].Price < _carsList[atual - 1].Price)
				{
					var aux = _carsList[atual];

					_carsList[atual] = _carsList[atual - 1];
					_carsList[atual - 1] = aux;

					atual--;
				}
			}
			Imprimir();
		}
		public void NearestZero()
		{
			int[] itens = { 12, 8, -10, 4, 1, 20, 32 };
			int differenceIndex = Math.Abs(itens[0] - 0);
			int nearestZero = int.MaxValue;

			for (int i = 0; i < itens.Length; i++)
			{
				differenceIndex = Math.Abs(itens[i] - 0);
				if (differenceIndex < nearestZero)
				{
					nearestZero = itens[i];
				}
			}
			Console.WriteLine(nearestZero);
		}
		public void CallingEachEveryMonthInPeriod()
		{
			DateTime? startDate = DateTime.Now;
			DateTime? endDate = DateTime.Now;
			DateTime filtroDataInicio = startDate ?? DateTime.UtcNow.AddMonths(-6);
			DateTime filtroDataFim = endDate ?? DateTime.UtcNow;
			CultureInfo _cultureInfo = new CultureInfo("pt-BR");

			var rangeDatas = filtroDataFim - filtroDataInicio;
			DateTime dataFinalNova;
			TimeSpan dataSomar = TimeSpan.FromDays(30);

			while (rangeDatas.TotalSeconds > 0)
			{
				if (rangeDatas.Days / dataSomar.Days > 0)
					dataFinalNova = filtroDataInicio.Add(dataSomar);
				else
					dataFinalNova = filtroDataFim;

				filtroDataInicio = dataFinalNova;
				rangeDatas = rangeDatas.Subtract(dataSomar);

			}

		}

		public bool ProbabilityGenerator(int probability)
		{
			Random Random = new Random();

			if (probability < 0 || probability > 100)
			{
				throw new ArgumentOutOfRangeException(nameof(probability), "Probability must be between 0 and 100.");
			}

			return Random.Next(1, 101) <= probability;
		}

		public void TestProbability(int attempts, int probability)
		{
			for (int i = 0; i < attempts; i++)
			{
				Console.WriteLine("result: " + ProbabilityGenerator(probability));
			}
		}
	}
}

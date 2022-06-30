using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace r3nan.dojo.console.Algoritmos
{
	internal class Algoritmo
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
				Console.WriteLine($" {item.Name} - Preço: { item.Price }");
			}
		}
		public void InsertionSort()
		{
			Console.WriteLine("Antesde ordenar:");

			foreach (var item in _carsList)
			{
				Console.WriteLine($" {item.Name } - { item.Price} ");
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
	}
}

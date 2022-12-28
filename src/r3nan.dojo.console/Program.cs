using Domain;
using System.Linq;
using r3nan.dojo.console.Algoritmos;
using r3nan.dojo.console.DependencyInjection;
using r3nan.dojo.console.Paralelism;
using r3nan.dojo.console.SOLID._2___Open_Closed_Principle;
using r3nan.dojo.console.SOLID._3___Liskov_substitution;
using r3nan.dojo.console.Lambda_LINQ;
using r3nan.dojo.console.Design_Patterns;
using System.Globalization;
using r3nan.dojo.console.Auth;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using r3nan.dojo.console.PollyActions;
using System.Text.RegularExpressions;
using r3nan.dojo.console.Databases;
using Microsoft.EntityFrameworkCore;



#region [EF Core]

//using var context = new EFInMemoryAccess();
//context.Database.EnsureCreated();

//var newBook = new Book { Title = "The Lambert", PublishDate = new DateTime(1987,1,2)};
//var newAuthor = new Author { FirstName = "William", LastName = "Faulkner" };

////updatebook
////newBook.Authors.Add(newAuthor);
////newAuthor.Books.Add(newBook);

//context.Books.Add(newBook);
//context.Authors.Add(newAuthor);

//context.SaveChanges();

//Console.WriteLine($"Adicionado book e author. Livro: { newBook.Title } - Author: { string.Join(" ", newAuthor.FirstName,newAuthor.LastName) } ");

//var authores = context.Authors
//	.ToList();
//	//.Include(i => i.Books)

//var books = context.Books
//	.ToList();
//	//.Include(a => a.Authors)

//Console.WriteLine("Listagem Ids livros e autores");
//foreach (var item in authores)
//{
//	Console.WriteLine($" {item.AuthorId} - {item.FirstName} - {item.Books.FirstOrDefault()?.Title}");
//}

//foreach (var item in books)
//{
//	Console.WriteLine($" {item.BookId} - {item.Title} - {item.Authors.FirstOrDefault()?.FirstName}");
//}

#endregion

#region [PlayGround]

//#if NET6_0_OR_GREATER
//Console.WriteLine("Hello .net 6+");
//#endif





//exampleStruct s1;
//s1.a = 10;
//s1.b = false;

//Console.WriteLine(s1.a);
//Console.WriteLine(s1.b);

//exampleClass s2 = new();
//s2.a = 100;
//s2.b = true;
////Console.WriteLine(s2.a);
//Console.WriteLine(s2.b);

//show total memory from GC
//Console.WriteLine(GC.GetTotalMemory(false));
//Collect * is just to learn, we dont need to do this
//GC.Collect();


//int? age = null;
//int result;

//if age is null,result receive 12, the age still null.
//result = age ?? 12;

//if age is null, assing 10 to age, the age is now with value.
//age ??= 10;


//Console.WriteLine("Idade");
//Console.WriteLine(age ?? 1);

//String formatting
//var f = 0f; // float
//var d = 0d; // double
//var m = 0m; // decimal (money)
//var u = 0u; // unsigned int
//var l = 0l; // long
//var ul = 0ul; // unsigned long


//Simplified way two decimal 
//decimal numberOne = 100.123M;
//Console.WriteLine(numberOne);
//inside string interpolation
//Console.WriteLine($"{numberOne:N2}");
//the same as the one above
//Console.WriteLine("{0}",numberOne.ToString("N2"));

//strings ###
//string nome = "jackson Pollock";

//Console.WriteLine(nome.LastIndexOf("l"));

//Regex
//Regex caption = new Regex(@"poll",RegexOptions.IgnoreCase);
//Regex caption2 = new Regex(@"[A-Z]");
//Console.WriteLine(caption2.IsMatch(nome));
////Replace with regex
//string result = caption2.Replace(nome, "***");
//Console.WriteLine(result);



//LINQ
//Console.WriteLine("LINQ:");
//List<int> numbers = new List<int>() { 1, 2, 3, 6, 8, 10 };

//var results = from query in numbers
//			 where query > 5
//			 select query;


//var resultShort = numbers.Where((digit,index) => digit > 6 && index > 2 ).ToList();
//Console.WriteLine("result short");
//resultShort.ForEach(x => Console.WriteLine(x));



#endregion

#region [Tips]
//last index list
//IEnumerable<int> numbers = new int[] { 1,2,5,7,9,12,16,22,4};
//Console.WriteLine(numbers.ElementAt(^1));

//FlattenLists
//var brandA = new Brand() { Name = "Hurl", Colors = new List<string>() { "White", "Black","Pink" } };
//var brandB = new Brand() { Name = "Corn", Colors = new List<string>() { "Red", "Yellow" , "Orange", "Purple" , "Grey" } };
//var brandC = new Brand() { Name = "Blow", Colors = new List<string>() { "Green", "Magenta" , "Ocean" } };

//List<Brand> brands = new List<Brand>() { brandA, brandB, brandC };

////Show colors inside one collection
//Console.WriteLine("Brands:");
//brandA.Colors.ForEach(x =>  Console.WriteLine(x));

////Just show colors inside a collection of collections
//Console.WriteLine("Brands within brands Lists:");
//brands.ForEach(x => x.Colors.ForEach(y => Console.WriteLine(y)));

////Flattern selection in one collection
//var brandsColors = brands.SelectMany(c => c.Colors);
//Console.WriteLine(" ");
//Console.WriteLine("brands foreach:");
//foreach (var item in brandsColors)
//{
//	Console.WriteLine(item);
//}

//Prevent a potential deadlock
//var semapore = new SemaphoreSlim(1);
//Dosomething(1);
//async void Dosomething(int valor)
//{
//	await semapore.WaitAsync();
//	try
//	{
//		await ComputeAsync(valor)
//	}
//	finally
//	{
//		semapore.Release();
//	}
//}
//async Task ComputeAsync(int valor) {
//	await Task.Delay(2000);
//	Console.WriteLine("hello");
//}


#endregion

#region [Globalization]

//Console.WriteLine(RegionInfo.CurrentRegion.Name);
//CultureInfo culture = new CultureInfo("pt-br");

//var preco = decimal.Parse("10,20", culture);

//Console.WriteLine($"O valor recebido é : {preco.ToString("C2",CultureInfo.InvariantCulture)} ");
//Console.WriteLine($"O valor recebido é : {preco:n2} ");
//Console.WriteLine($"O valor recebido é : {preco.ToString("C2",culture)} ");

#endregion

#region [.NET 6 Features]

//DateOnly and TimeOnly



#endregion

#region [Polly - Retry]

//Adding service collection

//PollyUse polly = new PollyUse();
//polly.MakeARequest().Wait(20000);

#endregion

#region [SOLID - Session]
// Open closed Principle
//IDog dog1 = new MuteDog();
//IDog dog2 = new Dog();
//Console.WriteLine("dog sound: " + dog1.MakeSound());
//Console.WriteLine("dog sound: " + dog2.MakeSound());

//Liskov Substitution principle
//IBirdsThatNotFly bird = new RubberBird();
//bird.Fly();

// Call dependency injection services
//DIContainer d1 = new();
//d1.CreateServices();
#endregion

#region [Algoritms]

//Algoritmo algo = new Algoritmo();
//algo.TestProbability(10, 85);

#endregion

#region [Threading And Paralelism]

//ThreadingStudy t1 = new ThreadingStudy();


#endregion

#region [LINQ, Delegates And Lambda]

//LambdaAndLINQ l1 = new LambdaAndLINQ();
//l1.testLINQ();

#endregion

#region [Generics, Sets, Dictionary]


#endregion

#region [DESIGN PATTERNS - Code]

//Car c1 = new Car();
//c1.Price = 52000.00M;
//Console.WriteLine(c1.Name);

//if (c1.Name is not null)
//{

//}
//CustoVeiculo custo = new CustoVeiculo(c1);

//Console.WriteLine(custo.ValorTotalVeiculo.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")));


#endregion

#region [String Manipulation]

//string testCase = "hI mY Name iS RenaN From FBI";
//TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
//TextInfo textPtBrInfo = new CultureInfo("pt-br", false).TextInfo;

//Console.WriteLine(testCase.ToLower());
//Console.WriteLine(testCase.ToUpper());
//Console.WriteLine(testCase.Normalize());
//Console.WriteLine(textInfo.ToTitleCase(testCase));
//Console.WriteLine(textPtBrInfo.ToTitleCase(testCase));

//Stringbuilder performance comparison

//Stopwatch sw = new Stopwatch();
//sw.Start();
//string testText = "";

//for (int i = 0; i < 100000; i++)
//{
//	testText += i;
//}

//sw.Stop();
//Console.WriteLine("Test with regular string concat:");
//Console.WriteLine($"{sw.ElapsedMilliseconds} ms");

//sw.Restart();

//StringBuilder sb = new StringBuilder();

//for (int i = 0; i < 100000; i++)
//{
//	sb.Append(i);
//}
//sw.Stop();
//Console.WriteLine("Test with string builder:");
//Console.WriteLine($"{sw.ElapsedMilliseconds} ms");

//arrays
//int[] ages = new int[] { 1, 4, 6, 12, 2, 0 };
//string results;

//results = String.Concat(ages);

//Console.WriteLine(results);

//results = String.Join(",", ages);

//Console.WriteLine(results);

//string testString2 = new string("jack,bob,jon,fel,dony,pol".Reverse().ToArray());
//string testString3 = new string("   jack,bob,jon,fel,dony,   pol      ");

//string [] results2 = testString3.Split(",");

//Array.ForEach(results2, x => Console.WriteLine(x));
//Console.WriteLine();
//Array.ForEach(results2.Reverse().ToArray(), x => Console.Write(x));
//Console.WriteLine();
//Array.ForEach(results2, x => Console.Write(x.Reverse().ToArray()));


//Console.WriteLine();

//results2 = testString2.Split(", ");

//Array.ForEach(results2, x => Console.WriteLine(x));

//Console.WriteLine(testString3.TrimStart());
//Console.WriteLine(testString3.TrimEnd());

//Console.WriteLine("sem espaços");
//Console.WriteLine(testString3.Where(c => !Char.IsWhiteSpace(c)).ToArray());


#endregion

#region [JWT]

//AuthWithJWT auth1 = new AuthWithJWT();

#endregion

#region [Features C#8]


//1*************RANGE INDEX
//string[] cursos = new string[] { "asp.net", "C#", "Angular", "Java" };
//foreach (var item in cursos[1..^1])
//{
//    Console.WriteLine($"{item}");
//}

//2*************FUNÇÕES LOCAIS ESTATICAS
//Console.WriteLine(Soma(5, 5));
//static int Soma(int a, int b) => a + b;


//3*************SWITCH
//var operador = "FX";
//var resultado = operador switch
//{
//    "-" => "Subtrair",
//    "+" => "Adição",
//    "x" => "multiplicação",
//    _ => "Operação desconhecida"
//};
//Console.WriteLine(resultado);


//4************switch com tuplas
//Console.WriteLine(RecuperaResultado((Resultado.Positivo, Resultado.Positivo), false));



//5************USINGS
//using var file = new System.IO.StreamWriter("file.txt");
//using(var file2 = new System.IO.StreamWriter("asdas.ttxt"))
//{
//    file2.
//}


//6*****************COALESCE C#3.0
//int? numero = null;
//int numero2 = 0;
//numero2 = numero ?? -1;

//////FORMA ANTIGA
//////if (numero != null)
//////{
//////    numero2 = numero.Value;
//////}
//////else
//////{
//////    numero2 = -1;
//////}
//Console.WriteLine(numero2);



//7*****************NULL CONDITIONAL C#6
//dynamic pessoa = new
//{
//    Cabeca = "grande",
//    Mao = "Pequena",
//    Pes = "Medios",
//};

////if (pessoa.Cabeca == "grande")
////{
////    Console.WriteLine("Cabeçudo");
////}
////else
////{
////    Console.WriteLine("Cabeça normal");
////}

//pessoa = null;

//if (pessoa?.Cabeca == "grande")
//{
//    Console.WriteLine("Cabeçudo");
//}
//else
//{
//    Console.WriteLine("Cabeça normal");
//}




//8*************************DESCARTES
//var (nome, sobrenome) = RetornaNomeSobrenome();
//Console.WriteLine($"{nome} {sobrenome}");

//var (nome2, _) = RetornaNomeSobrenome();
//Console.WriteLine($"{nome2}");



#endregion

#region [Features C#9]
//2 Top Levels calls

//string name = "Thiago";

// 1 Is not
//if (name is not null)
//	Console.WriteLine("Não é Nulo!");
//else
//	Console.WriteLine("É Nulo!");


//Console.WriteLine($"O resultado é: {Add(5, 5)}");

////4 Type shorthand instantiation - Atalho de instanciação de tipos
//Pessoa5 p = new() { Id = 1, Nome = "Thiago", SobreNome = "Pelissari" };

//p.SobreNome = "Pellizzari";

////Relational <, >, >=, <=
////Logical not, and, or

//int temp = 11;

////5. Relational & Logical pattern matching in switch expression
//string resultadoTemp = temp switch
//{
//	> 0 and <= 10 => "Frio",
//	<= -5 => " Muito Congelante",
//	_ => "Desconhecido"

//};


//Console.WriteLine($"Temperatura: {resultadoTemp}");


//double Add(double x, double y)
//{
//	return x + y;
//}
#endregion

#region [Features C#10]

public class csharp10
{
	//Namespace
	/// befor
	/// namespace renan.dojo.console {}
	/// now
	/// namespace renan.dojo.console;
	/// 

	//public const string Saudacao = "Bem-Vindo";
	//public const string Title = "Mr.";
	//public const string Name = "Renan";

	//public const string Salute = 
	//	$"\n{Saudacao}," +
	//	$" {Title}{Name}!\n";


}


#endregion

#region [Features C#11]

#endregion


public class exampleClass
{
	public int a { get; set; }
	public bool b { get; set; }

	public int shiftDays(DayOfWeek day) => day switch
	{
		DayOfWeek.Monday => 1,
		DayOfWeek.Sunday => 2,
		DayOfWeek.Saturday => 3,
		DayOfWeek.Tuesday => 4,
		DayOfWeek.Friday => 5,
		DayOfWeek.Wednesday => 6,
		DayOfWeek.Thursday => 7,
		_ => throw new NotImplementedException()
	};
}
public struct exampleStruct
{
	public int a;
	public bool b;
}

public record examlpleRecord : IExample
{
	public int a { get; set; }
	public bool b { get; set; }

	public void WhoAmI()
	{
		throw new NotImplementedException();
	}
}

public interface IExample
{
	public int a { get; set; }
	public bool b { get; set; }

	void WhoAmI();
}

public class SupportItens
{
	static (string, string) RetornaNomeSobrenome()
	{
		return ("Thiago", "Pellizzari");
	}

	static Resultado RecuperaResultado((Resultado, Resultado) result, bool perigo = false)
	{
		return result switch
		{
			(Resultado.Positivo, Resultado.Positivo) when perigo => Resultado.Negativo,
			(Resultado.Positivo, Resultado.Positivo) when !perigo => Resultado.Positivo,
			(_, _) => Resultado.Negativo
		};
	}
}

public enum Resultado
{
	Positivo,
	Negativo
}

public class Brand
{
	public string Name { get; set; }
	public List<string> Colors { get; set; }
}
using System;
using System.Collections.Generic;

namespace DIO.Sales
{
	class Program
	{
		static List<Vendedor> listVendedores = new List<Vendedor>();
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarVendedores();
						break;
					case "2":
						InserirVendedores();
						break;
                    case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}

		private static void InserirVendedores()
		{
			Console.WriteLine("Inserir novo vendedor");

			Console.Write("Digite o Nome do vendedor: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o valor da venda: ");
			double entradaSaldo = double.Parse(Console.ReadLine());

		
			Vendedor novoVendedor = new Vendedor(entradaNome,entradaSaldo);

			listVendedores.Add(novoVendedor);
		}

		private static void ListarVendedores()
		{
			Console.WriteLine("Listar vendedores");

			if (listVendedores.Count == 0)
			{
				Console.WriteLine("Nenhum cadastro encontrado.");
				return;
			}

			for (int i = 0; i < listVendedores.Count; i++)
			{
				Vendedor vendedor01 = listVendedores[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(vendedor01);
			}
		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Sales a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar vendedores");
			Console.WriteLine("2- Inserir novo usuário");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}
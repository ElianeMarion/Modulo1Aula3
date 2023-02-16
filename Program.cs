namespace Aula03
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Aula 03 - Continuação das estruturas de decisão");
			/*
			string usuario, senha;
			Console.WriteLine("Usuário: ");
			usuario = Console.ReadLine();
			Console.WriteLine("Senha: ");
			senha = Console.ReadLine();

			if(usuario == "administrador" && senha == "123")
			{
				Console.WriteLine("Acesso liberado");
			}
			else
			{
				Console.WriteLine("!\nAcesso Negado!\n");
				if(usuario != "administrador")
					Console.WriteLine("Usuário inválido");

				if (senha != "123")
					Console.WriteLine("Senha inválida!");


				if (usuario != "administrador" && senha != "123")
					Console.WriteLine("!\nAcesso Negado!\nUsuário e senha inválidos");
				else if (usuario != "administrador")
					Console.WriteLine("Usuário inválido");
				else
					Console.WriteLine("Senha inválida!");
			}
			*/
			/*Faça um programa que receba o total de compras de um usuário e um cupom. 
			 * Se o total de compras exceder 1000 ou se o cupom for igual a DESCONTO20, 
			 * aplicar um desconto de 20% na compra.
			 */
			/*double totalCompra, valorFinal;
			string desconto;
			Console.WriteLine("Digite o total da compra R$: ");
			totalCompra = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite o cupom de desconto: ");
			desconto = Console.ReadLine();
			if (totalCompra > 1000 || desconto == "DESCONTO20")
				valorFinal = totalCompra - totalCompra * 0.2;
			else
				valorFinal = totalCompra;

			//Console.WriteLine("Total da compra = R$" + valorFinal);
			Console.WriteLine("Total da compra = R$ {0}", valorFinal.ToString("0.00"));

			/*Crie um programa que permita que receba o tipo de um usuário em uma variável String, 
			 * e caso esse tipo NÃO SEJA “administrador”, exiba a mensagem: 
			 * “Atenção, usuário sem poderes administrativos. Algumas tarefas serão bloqueadas”.
*/
			/*	string tipoUsuario;
				Console.WriteLine("Informe o tipo de usuário: ");
				tipoUsuario= Console.ReadLine();
				if (!(tipoUsuario == "administrador")) //tipoUsuario != "administrador
					Console.WriteLine("Atenção, usuário sem poderes administrativos.Algumas tarefas serão bloqueadas");
				else
					Console.WriteLine("Bem vindo! ");*/

			/*int codigo;
			string mensagem;
			Console.WriteLine("Digite o código: ");
			codigo = Convert.ToInt16(Console.ReadLine());
			switch(codigo)
			{
				case 1: //codigo ==1
					mensagem = "Você escolheu a opção ELOGIO PROFISSIONAL"; 
					break;
				case 2:
					mensagem = "Você escolheu a opção ELOGIO FÍSICO";
					break;
				case 3:
					mensagem = "Você escolheu a opção ELOGIO PESSOAL";
					break;
				default:
					mensagem = "Opção inválida";
					break;
			}
			Console.WriteLine(mensagem);
			*/
			/*
						int l1, l2, l3;
						Console.WriteLine("Digite o primeiro lado do triangulo: ");
						l1= Convert.ToInt16(Console.ReadLine());

						Console.WriteLine("Digite o segundo lado do triangulo: ");
						l2 = Convert.ToInt16(Console.ReadLine());

						Console.WriteLine("Digite o terceiro lado do triangulo: ");
						l3 = Convert.ToInt16(Console.ReadLine());

						//Verificação se é um triângulo
						if(l1 < l2 + l3 && l2 < l1 + l3 && l3 < l1 + l2 )
						{
							Console.WriteLine("É um triângulo");
							if (l1 == l2 && l2 == l3)
								Console.WriteLine("\nEquilátero");
							else if(l1 != l2 && l1 != l3 && l2 != l3)
								Console.WriteLine("\nEscaleno");
							else
								Console.WriteLine("\nIsoscéles");

							//if((l1 == l2 && l1 != l3) || (l1 == l3 && l1 != l2) || (l2 == l3 && l2 != l1)
						}
						else
							Console.WriteLine("Não formam um triângulo");

						/*Utilizando a estrutura switch case, elabore um programa que leia um número referente 
						 * a um mês do ano e exiba o nome do mês. Se for digitado um valor que não corresponda 
						 * a um mês válido, exiba uma mensagem indicando tal situação.
						*/
			/*int mes;
			Console.WriteLine("Digite um número referente ao mês do ano: ");
			mes = Convert.ToInt16(Console.ReadLine());
			switch (mes)
			{
				case 1:
					Console.WriteLine("Janeiro");
					break;
				case 2:
					Console.WriteLine("Fevereiro");
					break;
				case 3:
					Console.WriteLine("Março");
					break;
				case 4:
					Console.WriteLine("Abril");
					break;
				case 5:
					Console.WriteLine("Maio");
					break;
				case 6:
					Console.WriteLine("Junho");
					break;
				case 7:
					Console.WriteLine("Julho");
					break;
				case 8:
					Console.WriteLine("Agosto");
					break;
				case 9:
					Console.WriteLine("Setembro");
					break;
				case 10:
					Console.WriteLine("Outubro");
					break;
				case 11:
					Console.WriteLine("Novembro");
					break;
				case 12:
					Console.WriteLine("Dezembro");
					break;
				default:
					Console.WriteLine("Mês inválido!");
					break;
			

			}
			*/

			double nota1, nota2, media, aulasAssistidas, aulasDadas, frequencia;
			Console.WriteLine("Digite a primeira nota do aluno: ");
			nota1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a segunda nota do aluno: ");
			nota2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a quantidade de aulas assistidas: ");
			aulasAssistidas = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a quantidade de aulas dadas: ");
			aulasDadas = Convert.ToDouble(Console.ReadLine());
			media = (nota1 + nota2) / 2;
			frequencia = (aulasAssistidas / aulasDadas) * 100;
			if (media >= 7 && frequencia >= 75)
				Console.WriteLine("Aluno aprovado com media = " + media + " e frequencia = " + frequencia + "%");
			else
				Console.WriteLine("Aluno reprovado com media = " + media + " e frequencia = " + frequencia + "%");
		}

		/*
		 * !
		 * &&
		 * ||
		 */
	}
}
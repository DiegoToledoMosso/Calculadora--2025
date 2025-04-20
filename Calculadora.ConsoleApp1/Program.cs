using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Calculadora.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] historicoOperacoes = new string[100];

            int contadorHistorico = 0;


            while (true)
            {

                string opcao = ExibirMenu();


                if (OpcaoSairFoiEscolhida(opcao))
                    break;

                else if (OpcaoTabuadaFoiEscolhida(opcao))
                    ExibirTabuada();

                else if (opcao == "6")
                    ExibirHistoricoDeOperacoes(contadorHistorico, historicoOperacoes);

                else
                {
                    decimal resultado = RealizarCalculo(opcao, contadorHistorico, historicoOperacoes);

                    ExibirResultado(resultado);
                }


                Console.ReadLine();

            }


        }

        static string ExibirMenu()
        {

            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("------------------------------------");




            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - tabuada");
            Console.WriteLine("6 - Historico");
            Console.WriteLine("S - Sair");
            Console.WriteLine("------------------------------------");


            Console.WriteLine("Escolha uma opção");
            string opcao = Console.ReadLine();

            return opcao;
        }

        static bool OpcaoSairFoiEscolhida(string opcao)
        {
            bool opcaoSairFoiEscolhida = opcao == "s";

            return opcaoSairFoiEscolhida;
        }

        static bool OpcaoTabuadaFoiEscolhida(string opcao)
        {
            bool opcaoTabuadaFoiEscolhida = opcao == "5";

            return opcaoTabuadaFoiEscolhida;
        }

        static void ExibirTabuada()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Tabuada Tabajara");
            Console.WriteLine("------------------------------------");

            Console.Write("Digite o número desejado para a tabuada: ");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());



            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{numeroTabuada} x {contador} = {numeroTabuada * contador}");

                //int resultadomultiplicacao = numeroTabuada * contador;

                //string linhaDaTabuada = numeroTabuada + " x " + contador + " = " + resultadomultiplicacao;

                //Console.WriteLine(linhaDaTabuada);
            }

            Console.ReadLine();
        }

        static bool OpcaoHistoricoFoiEscolhida(string opcao)
        {
            return opcao == "6";
        }

        static void ExibirHistoricoDeOperacoes(int contadorHistorico, string[] historicoOperacoes)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Historico de Operações");
            Console.WriteLine("------------------------------------");

            for (int contador = 0; contador <= contadorHistorico; contador++)
            {
                Console.WriteLine(historicoOperacoes[contador]);

            }

            Console.ReadLine();
        }

        static decimal RealizarCalculo (string opcao, int contadorHistorico, string[] historicoOperacoes)
        {
            Console.WriteLine("------------------------------------");
            Console.Write("Digite o primeiro número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            //numero decimais(com casas)
            //float resultadoFloat = 0.1212311f;
            //double resultadoDouble = 0.212312313132131;

            decimal resultado = 0.0m;


            if (opcao == "1")
            {
                //Soma
                resultado = primeiroNumero + segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            }
            else if (opcao == "2")
            {
                //subtração
                resultado = primeiroNumero - segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";

            }
            else if (opcao == "3")
            {
                //Multiplicação
                resultado = primeiroNumero * segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
            }
            else if (opcao == "4")
            {
                while (segundoNumero == 0)
                {
                    Console.Write(" > Digite o segundo número novamente");

                    segundoNumero = Convert.ToDecimal(Console.ReadLine());

                    //------Modo padrão para voltar para o começo das opçoes da calculadora------
                    //Console.WriteLine("Não é possível dividir por zero");
                    //Console.ReadLine();
                    //continue;
                }

                resultado = primeiroNumero / segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            }
            contadorHistorico++;

            return resultado;
        }

        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Resultado é : " + resultado.ToString("F2"));
            Console.WriteLine("------------------------------------");
        }

            
    }
}

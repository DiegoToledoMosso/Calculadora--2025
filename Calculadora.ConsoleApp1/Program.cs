using System.ComponentModel.Design;

namespace Calculadora.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            //vetores
            string[] historicoOperacoes = new string[100];

            int contadorHistorico = 0;
            

            
            //loop de execução - estrutura de repetição
            while (true) 
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
                Console.WriteLine("S - Sair");
                Console.WriteLine("------------------------------------");


                Console.WriteLine("Escolha uma opção");
                string opcao = Console.ReadLine();


               
                if (opcao == "S")                
                    break;

                else if (opcao == "5")
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Tabuada Tabajara");
                    Console.WriteLine("------------------------------------");

                    Console.Write("Digite o número desejado para a tabuada: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());


                    // 1 - contador = variavel de controle
                    // 2 - condição
                    // 3 - mecanismo de incrementação


                    for (int contador = 1; contador <= 10; contador++)
                    {

                        int resultadomultiplicacao = numeroTabuada * contador;

                        string linhaDaTabuada = numeroTabuada + " x " + contador + " = " + resultadomultiplicacao;

                        Console.WriteLine(linhaDaTabuada);
                    }

                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Historico de Operações");
                    Console.WriteLine("------------------------------------");

                    for (int contador = 0; contador <= contadorHistorico; contador++)
                    {
                        Console.WriteLine(historicoOperacoes[contador]);               
                    
                    }
                    
                    Console.ReadLine();
                    continue;


                }



                    Console.WriteLine("------------------------------------");
                Console.Write("Digite o primeiro número: ");
                string strprimeiroNumero = Console.ReadLine();

                decimal primeiroNumero = Convert.ToDecimal(strprimeiroNumero);


                Console.Write("Digite o segundo número: ");
                string strsegundoNumero = Console.ReadLine();

                decimal segundoNumero = Convert.ToDecimal(strsegundoNumero);

                //numero decimais(com casas)
                //float resultadoFloat = 0.1212311f;
                //double resultadoDouble = 0.212312313132131;

                decimal resultado = 0.0m;

                //estrutura de decisão se(if)
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
                else
                    continue;

                contadorHistorico++;    




                    Console.WriteLine("------------------------------------");
                Console.WriteLine("Resultado é : " + resultado.ToString("F2")); //flo
                Console.WriteLine("------------------------------------");

                Console.ReadLine();


            }


            
        }
    }
}

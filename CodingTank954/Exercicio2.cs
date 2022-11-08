using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank954
{
    public class Exercicio2
    {
        static void Main()
        {
            /*
             * Faça um programa que apresente quatro opções:
             * (a) consulta saldo, (b) saque, (c) depósito e (d) sair.
             * O saldo deve iniciar em R$ 0,00.
             * A cada saque ou depósito o valor do saldo deve ser atualizado e apresentado na tela.
             */

            Console.WriteLine("Bem-vindo ao Banco");

            decimal saldo = 0;
            string opcao = "";

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            do
            {
                bool exibirSaldo = true;
                Console.WriteLine("Digite (a) para consultar saldo");
                Console.WriteLine("Digite (b) para sacar");
                Console.WriteLine("Digite (c) para depositar");
                Console.WriteLine("Digite (d) para sair");
                opcao = Console.ReadLine().ToLower();

                if (opcao == "b")
                {
                    Console.WriteLine("Digite sua senha:");
                    string senhaSaque = Console.ReadLine();

                    if (senhaSaque != senha)
                    {
                        Console.WriteLine("Senha incorreta, saque não permitido");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    Console.WriteLine("Digite o valor a ser sacado:");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    if (saldo >= valorSaque)
                    {
                        saldo -= valorSaque;
                    }
                    else
                    {
                        Console.WriteLine("Saldo em conta insuficiente!");
                    }
                }
                else if (opcao == "c")
                {
                    Console.WriteLine("Digite o valor a ser depositado");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    saldo += valorDeposito;
                }
                else if (opcao == "d")
                {
                    exibirSaldo = false;
                }

                if (exibirSaldo)
                {
                    Console.WriteLine($"Saldo atual da conta: {saldo}");
                }

                Console.WriteLine("Pressione para continuar..");
                Console.ReadKey();
                Console.Clear();

            } while (opcao != "d");

        }
    }
}

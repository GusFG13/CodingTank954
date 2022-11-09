﻿namespace CodingTank954
{
    public class Exercicio4
    {
        public static void MainEx4(string[] args)
        {
            /*
             * Um comerciante comprou um produto e
             * quer vende-lo com um lucro de 45%
             * se o valor da compra for menor que R$20,00;
             * caso contrário, o lucro será de 30%.
             * Entrar como valor do produto e imprimir o valor da venda.
             */

            Console.WriteLine("Qual o valor do produto? ");
            decimal valorProduto = decimal.Parse(Console.ReadLine());

            decimal percentualVenda = valorProduto < 20 ? 1.45M : 1.30M;

            decimal valorFinal = valorProduto * percentualVenda;
            Console.WriteLine("O valor de venda será: " + valorFinal);
        }
    }
}

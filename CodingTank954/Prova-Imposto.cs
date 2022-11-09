namespace CodingTank954
{
    public class Prova_Imposto
    {
        static void Main(string[] args)
        {
            /*
             * Uma empresa vende o mesmo produto para diferentes estados.
             * Cada estado possui uma taxa diferente de imposto sobre o produto
             * (MG 7%; SP 12%; RJ 15%; MS 8%; ES 12%; SC 18%;).
             * Faça um programa em que o usuário entre com o valor e o estado de destino do produto
             * e o programa retorne o preço final do produto acrescido do imposto do estado em que ele será vendido.
             * Se o estado digitado não for válido, mostrar uma mensagem de erro.
             * O usuário deve utilizar o programa obtendo o preço final até que ele digite SAIR.
             */

            do
            {
                Console.WriteLine("Informe o valor do produto ou SAIR para encerrar o programa:");
                string info = Console.ReadLine().ToLower();

                if (info == "sair")
                {
                    break;
                }

                double.TryParse(info, out double valor);

                Console.WriteLine("\nCálculo disponível para os seguintes estados:");
                Console.WriteLine("MG | SP | RJ | MS | ES | SC");
                Console.WriteLine("Informe a sigla de um estado válido.");
                string estado = Console.ReadLine().ToUpper();

                if (estado == "MG")
                {
                    valor *= 1.07;
                }
                else if (estado == "SP")
                {
                    valor *= 1.12;
                }
                else if (estado == "RJ")
                {
                    valor *= 1.15;
                }
                else if (estado == "MS")
                {
                    valor *= 1.08;
                }
                else if (estado == "ES")
                {
                    valor *= 1.12;
                }
                else if (estado == "SC")
                {
                    valor *= 1.18;
                }
                else
                {
                    Console.WriteLine("\nEstado inválido, tente novamente!\n\n");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine($"\nO valor final do produto é: {Math.Round(valor, 2)}\n\n");

            } while (true);
        }
    }
}

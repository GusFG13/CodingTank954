namespace CodingTank954
{
    public class Exercicio1
    {
        static void MainEx1()
        {

            /* 
             * Ler um vetor com 10 inteiros e
             * descubra o maior e o menor elemento do vetor.
             */

            int[] vetorInteiros = new int[10];
            int maiorValor = int.MinValue;
            int menorValor = int.MaxValue;

            for (int contador = 0; contador < 10; contador++)
            {
                string numero = "";


                while (true)
                {
                    Console.WriteLine($"Digite o número {contador + 1} do vetor: ");
                    numero = Console.ReadLine();
                    
                    if (int.TryParse(numero, out vetorInteiros[contador]))
                    {
                        break;
                    }
                    Console.WriteLine("Número incorreto, tente novamente");
                }
                

                if (vetorInteiros[contador] > maiorValor)
                {
                    maiorValor = vetorInteiros[contador];
                }

                if (vetorInteiros[contador] < menorValor)
                {
                    menorValor = vetorInteiros[contador];
                }
            }

            Console.WriteLine($"O maior número do vetor é o {maiorValor}");
            Console.WriteLine($"O menor número do vetor é o {menorValor}");

        }
    }
}

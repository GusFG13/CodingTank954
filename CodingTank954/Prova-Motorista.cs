namespace CodingTank954
{
    public class Prova_Motorista
    {
        static void MainMotorista(string[] args)
        {
            /*
             * Faça um algoritmo que leia o nome, a idade, e se tem carteira de motorista de 15 pessoas. Implemente as seguintes regras:

                Caso a idade seja menor que 18 anos, não pergunte se tem carteira de motorista.
                Precisamos de dois motoristas para dirigir em uma viagem.
                Ao identificar os dois primeiros, pare o questionário.
                Ao final, exiba o nome dos motoristas ou caso não encontre os dois, exiba: viagem não será realizada devido falta de motoristas.

            */

            string[] nome = new string[15];
            int[] idade = new int[15];
            string[] carteiraDeMotorista = new string[15];
            string[] motoristas = new string[2];
            int contador = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Informe o nome da {i + 1 }ª pessoa");
                nome[i] = Console.ReadLine();
                Console.WriteLine($"Informe a idade da {i + 1}ª pessoa");
                int.TryParse(Console.ReadLine(), out idade[i]);

                if (idade[i] < 18)
                {
                    continue; //proxima pessoa
                }

                Console.WriteLine($"Informe se {i + 1}ª pessoa tem carteira de motorista? SIM ou NÃO");
                carteiraDeMotorista[i] = Console.ReadLine().ToLower();

                if (carteiraDeMotorista[i] == "sim")
                {
                    motoristas[contador] = nome[i];
                    contador++;
                    if (contador == 2)
                    {
                        break; //termina questionario
                    }
                }
            }
            if (contador == 2)
            {
                Console.WriteLine($"\nUhuu! Os motorista são {motoristas[0]} e {motoristas[1]}");
            }
            else
            {
                Console.WriteLine("\nA viagem não será realizada devido falta de motoristas!");
            }

        }

    }
}

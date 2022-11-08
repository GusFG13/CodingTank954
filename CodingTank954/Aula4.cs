namespace CodingTank954
{
    public class Aula4
    {
        static void Main4(string[] args)
        {

            //for(inicialização; condição; incremento)

            //decimal[] notasAluno = new decimal[4];
            //decimal somaNotas = 0;
            //for (int contador = 0; contador < notasAluno.Length; contador++)
            //{
            //    Console.WriteLine($"Valor do contador: {contador}\n\n");

            //    Console.WriteLine($"Digite a nota {contador + 1} do aluno: ");
            //    notasAluno[contador] = decimal.Parse(Console.ReadLine());

            //    somaNotas += notasAluno[contador];
            //}
            //decimal mediaFinal = somaNotas / notasAluno.Length;

            //Console.WriteLine($"\n\nMédia final do aluno {mediaFinal}");

            //foreach (decimal nota in notasAluno)
            //{
            //    Console.WriteLine($"Nota do aluno: {nota}");
            //}

            //for (int contador = 0; contador < notasAluno.Length; contador++)
            //{
            //    Console.WriteLine($"Nota {contador + 1} do aluno: {notasAluno[contador]}");
            //}

            // Programa que calcula a idade média de um grupo de pessoas.
            // A finalização da entrada de números é dada por um -1
            // Se a idade for menor que 18, não utilize na média.


            //decimal idade = 0, somaIdades = 0, quantidade = 0;
            //decimal media = 0;

            //while (idade != -1)
            //{
            //    Console.WriteLine("Digite -1 para encerrar e calcular a média");
            //    Console.WriteLine("ou digite a idade da pessoa:");
            //    idade = decimal.Parse(Console.ReadLine());

            //    //if (idade == -1)
            //    //{
            //    //    break; //para todo o loop/ toda a estrutura de repetição
            //    //}

            //    //if (idade < 18)
            //    //{
            //    //    continue; // para somente o loop iterado, continua na proxima repetição
            //    //}

            //    if (idade >= 18)
            //    {
            //        somaIdades += idade;
            //        quantidade++;
            //    }
            //}

            //media = somaIdades / quantidade;
            //Console.WriteLine($"A média das idades é {media}");


            decimal idade = 0, somaIdades = 0, quantidade = 0;
            decimal media = 0;

            do
            {
                Console.WriteLine("Digite -1 para encerrar e calcular a média");
                Console.WriteLine("ou digite a idade da pessoa:");
                idade = decimal.Parse(Console.ReadLine());

                //if (idade == -1)
                //{
                //    break; //para todo o loop/ toda a estrutura de repetição
                //}

                //if (idade < 18)
                //{
                //    continue; // para somente o loop iterado, continua na proxima repetição
                //}

                if (idade >= 18)
                {
                    somaIdades += idade;
                    quantidade++;
                }
            } while (idade != -1);

            media = somaIdades / quantidade;
            Console.WriteLine($"A média das idades é {media}");

        }
    }
}

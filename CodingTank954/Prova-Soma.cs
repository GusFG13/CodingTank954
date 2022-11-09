namespace CodingTank954
{
    public class Prova_Soma
    {
        static void MainSoma(string[] args)
        {
            /*
             * Faça uma prova de matemática para crianças que estão aprendendo a somar números inteiros menores do que 100.
             * Escolha números aleatórios entre 1 e 100,
             * e mostre na tela a pergunta: qual é a soma de a + b,
             * onde a e b são os números aleatórios.
             * Peça a resposta.
             * Faça cinco perguntas ao aluno, e     *** Faça as perguntas e colete as respostas
             * mostre para ele as perguntas         *** Mostre a pergunta realizada
             * e as respostas corretas,             *** Mostre a resposta correta
             * além de quais o aluno acertou.       *** Informe se o aluno acertou
             */
            var numeroAleatorio = new Random();
            string[] perguntas = new string[5];
            int[] respostasDadas = new int[5];
            int[] respostasCorretas = new int[5];

            for (int i = 0; i < perguntas.Length; i++)
            {
                var a = numeroAleatorio.Next(1, 100);
                var b = numeroAleatorio.Next(1, 100);

                perguntas[i] = $"Quanto é {a} + {b}?";
                respostasCorretas[i] = a + b;

                Console.WriteLine(perguntas[i]);
                int.TryParse(Console.ReadLine(), out respostasDadas[i]);
            }

            for (int i = 0; i < perguntas.Length; i++)
            {
                Console.WriteLine($"Questão {i + 1}: ");
                Console.WriteLine(perguntas[i]);
                Console.WriteLine("Resultado: ");
                if (respostasCorretas[i] == respostasDadas[i])
                {
                    Console.WriteLine($"Você acertou! A resposta era: {respostasCorretas[i]}");
                }
                else
                {
                    Console.WriteLine($"Você errou... A resposta era: {respostasCorretas[i]}, mas sua resposta foi: {respostasDadas[i]}.");
                }
            }
        }
    }
}

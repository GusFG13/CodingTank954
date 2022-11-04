namespace CodingTank954
{
    public class Aula3
    {
        static void Main()
        {
            //Console.WriteLine("Digite um numero inteiro");
            //int numeroDigitado = int.Parse(Console.ReadLine());

            ////SE
            //if (numeroDigitado == 10)
            //{
            //    Console.WriteLine("Número digitado é igual a dez");
            //}
            ////SE NAO, SE
            //else if (numeroDigitado > 10)
            //{
            //    Console.WriteLine("Numero maior que dez");
            //}
            ////SENAO, SE
            //else if (numeroDigitado > 20)
            //{
            //    Console.WriteLine("Numero maior que vinte");
            //}
            ////SENAO
            //else
            //{
            //    Console.WriteLine("Numero menor que dez");
            //}

            //Console.WriteLine("Fim do nosso programa");

            /*
             * > maior
             * < menor
             * >= maior ou igual
             * <= menor ou igual
             * == igual
             * != diferente
             */

            //Console.WriteLine("Digite seu nome");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Digite seu sobrenome");
            //string sobrenome = Console.ReadLine();

            //nome = nome.ToUpper();
            //sobrenome = sobrenome.ToUpper();

            //if ((nome == "AMANDA" && sobrenome == "Mantovani".ToUpper()) ||
            //    (nome == "Eduardo".ToUpper() && sobrenome == "Junior".ToUpper()) ||
            //    (nome == "Joel".ToUpper() && sobrenome == "Alves".ToUpper()))
            //{
            //    Console.WriteLine("Olá professor(a)");
            //}
            //else
            //{
            //    Console.WriteLine("Olá aluno");
            //}

            /*
             * O Cinema Ada é uma franquia nacional e disponibiliza valor de meia entrada nas seguintes condições:
            Estudante;
            Doador de sangue;
            Trabalhador da prefeitura e a prefeitura possui contrato firmado com o cinema.
            Realize um questionário S e N e exiba se a pessoa tem direito a meia entrada ou não.
            */

            //Console.WriteLine("CINEMA ADA\n");
            //Console.WriteLine("Responda S - SIM ou N - NÃO\n");
            //Console.WriteLine("Você é estudante?");
            //string estudante = Console.ReadLine();

            //Console.WriteLine("\nVocê é doador de sangue? ");
            //string doadorDeSangue = Console.ReadLine();

            //Console.WriteLine("\nVocê trabalha na prefeitura? ");
            //string trabalhadorPrefeitura = Console.ReadLine();

            //Console.WriteLine("\nPrefeitura possui contrato com o cinema? ");
            //string contratoComCinema = Console.ReadLine();

            //if (estudante == "S" ||
            //    doadorDeSangue == "S" ||
            //    (trabalhadorPrefeitura == "S" && contratoComCinema == "S"))
            //{
            //    Console.WriteLine("Você tem direito a meia entrada!!! UHUUU");
            //}
            //else
            //{
            //    Console.WriteLine("Você paga inteira! Que pena! :( ");
            //}

            Console.WriteLine("CINEMA ADA\n");
            Console.WriteLine("Responda S - SIM ou N - NÃO\n");

            Console.WriteLine("Você é estudante?");
            bool estudante = (Console.ReadLine() == "S");

            Console.WriteLine("\nVocê é doador de sangue? ");
            bool doadorDeSangue = (Console.ReadLine() == "S");

            Console.WriteLine("\nVocê trabalha na prefeitura? ");
            bool trabalhadorPrefeitura = (Console.ReadLine() == "S");

            Console.WriteLine("\nPrefeitura possui contrato com o cinema? ");
            bool contratoComCinema = (Console.ReadLine() == "S");

            if (estudante ||
                doadorDeSangue ||
                (trabalhadorPrefeitura && contratoComCinema))
            {
                Console.WriteLine("Você tem direito a meia entrada!!! UHUUU");
            }
            else
            {
                Console.WriteLine("Você paga inteira! Que pena! :( ");
            }
        }
    }
}

namespace CodingTank954
{
    public class Aula2
    {
        static void MainAula2()
        {

            //DateTime dataHoje = new DateTime(2022, 11, 03);

            //Console.WriteLine(dataHoje);

            //DateTime dataHoraHoje = new DateTime(2022, 11, 03, 19, 25, 30);

            //Console.WriteLine(dataHoraHoje);

            //DateTime dataHoraSistema = DateTime.Now;

            //Console.WriteLine(dataHoraSistema);

            //Console.WriteLine(dataHoraHoje.Year);

            //Console.WriteLine(dataHoraSistema.ToShortDateString());
            //dataHoraSistema.ToShortTimeString();

            //dataHoraSistema.AddDays(-5);

            //Console.WriteLine(dataHoraSistema.Hour);
            //Console.WriteLine(dataHoraSistema.DayOfYear);

            //int idade = 10;


            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            string idade = Console.ReadLine();

            //int idade2 = 10;

            //Console.WriteLine();

            string frase = "Bem-vindo(a) " + nome + " ao curso, Bonde dos " + idade + " anos.";

            Console.WriteLine(frase);

            frase = string.Format("Bem-vindo(a) {0} ao curso, Bonde dos {1} anos", nome, idade);

            Console.WriteLine(frase);

            Console.WriteLine($"Bem-vindo(a) {nome} ao curso, Bonde dos {idade} anos.");

            /*//Exercicio: Crie um cadastro de uma biblioteca.
                    Leia os seguintes dados:
                    Título
                    Subtitulo
                    Autor
                    Editora
                    Número de páginas
                    Data de publicação
                    Idioma
                    Após receber os dados, limpe o console e exiba os dados na tela.

             * Altere o cadastro da biblioteca para exibir os dados na seguinte formatação:
             * Limpa a tela:
                Livro cadastrada com sucesso!
                Livro: Titulo - Subtitulo
                Autor: Nome do autor
                Editora: Editora
                Detalhes: Publicado em 15/07/2001 com 99 páginas em Português.
            */

            //cast implicito
            double valor = 1;

            //cast explicito
            //int valorint = 10.7;
            int valorint = (int)10.7;

            Console.WriteLine(valorint);

            //convert
            valorint = Convert.ToInt32("12");
            Console.WriteLine(valorint);

            DateTime dataHoje = Convert.ToDateTime("04/11/2022 05:08:24");
            Console.WriteLine(dataHoje);

            Convert.ToDouble("");
            Convert.ToDecimal("");

            //parse
            valorint = int.Parse("154");
            Console.WriteLine(valorint);

            decimal.Parse("123");

            //tente converter criando uma variavel 
            int.TryParse("250", out int valorConvertido);

            //tente converter para uma variavel existente
            bool sucesso = int.TryParse("-", out valorint);

            Console.WriteLine("Conversão do valor incorreto");
            Console.WriteLine($"Conversão realizada com sucesso? {sucesso}");
            Console.WriteLine(valorint);

            string valorTexto = "10";

            //bool conversaoRealizada = tipo.TryParse(valor que quero converte, variavel que receberá o valor)
            sucesso = int.TryParse(valorTexto, out valorint);

            Console.WriteLine("Conversão do valor correto");
            Console.WriteLine($"Conversão realizada com sucesso? {sucesso}");
            Console.WriteLine(valorint);

            DateTime.TryParse(Console.ReadLine(), out DateTime dataPublicacao);


            //Console.Clear();
            Console.WriteLine("Informe o titulo do livro: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Informe o subtitulo do livro: ");
            string subt = Console.ReadLine();

            Console.WriteLine("Informe o autor do livro: ");
            string aut = Console.ReadLine();

            Console.WriteLine("Informe a editora: ");
            string editora = Console.ReadLine();

            Console.WriteLine("Número de Páginas: ");
            string numeroPaginas = Console.ReadLine();

            Console.WriteLine("Data Publicação: ");
            DateTime datPubli = DateTime.Parse(Console.ReadLine());

            datPubli = Convert.ToDateTime(Console.ReadLine());

            DateTime.TryParse(Console.ReadLine(), out dataPublicacao);

            Console.WriteLine("Idioma: ");
            string idioma = Console.ReadLine();

            double valor1 = 15;
            double valor2 = 7;

            double soma = valor1 + valor2;
            double subtracao = valor1 - valor2;
            double divisao = valor1 / valor2;
            double multiplicacao = valor1 * valor2;

            double valor3 = 27.678541D;

            Console.WriteLine(soma);
            Console.WriteLine(subtracao);
            Console.WriteLine(divisao);
            Console.WriteLine(multiplicacao);

            Console.WriteLine(Math.Round(valor3, 2));

            double valor4 = Math.Pow(valor1, 2);
            Console.WriteLine(valor4);

            Math.Sqrt(25);
            

        }
    }
}

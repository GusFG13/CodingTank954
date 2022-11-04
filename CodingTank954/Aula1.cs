using System;

class Hello
{
    static void MainAula1()
    {
        Console.WriteLine("Valores inteiros");

        /*
         * Bloco de Comentario
         * Vai ser ignorado
         */

        //int valorInteiro;
        int valorInteiro = 10;

        Console.WriteLine(valorInteiro);

        valorInteiro = 20;

        Console.WriteLine("Variavel alterada");
        Console.WriteLine(valorInteiro);

        Console.WriteLine("  ----  ");
        Console.WriteLine("Variaveis de casas decimais (ponto flutuante)");

        float valorFloat = 10.4F;

        double valorDouble = 11.6;
        double valorDouble2 = 15.7D;

        decimal valorDecimal = 25.8M;

        Console.WriteLine(valorFloat);
        Console.WriteLine(valorDouble);
        Console.WriteLine(valorDecimal);

        Console.WriteLine(" ----- ");
        Console.WriteLine("Variaveis de texto");

        char valorChar = 'A';

        string valorTexto = "Bem vindos ao coding tank C# Turma 954";

        //valorTexto.Replace("a", "outro");
        Console.WriteLine(valorChar);
        Console.WriteLine(valorTexto);

        Console.WriteLine(" ----- ");
        Console.WriteLine("Variaveis de valor lógico");

        bool valorLogico = true;

        Console.WriteLine(valorLogico);

        valorLogico = false;

        Console.WriteLine(valorLogico);

        Console.WriteLine(" ----- ");
        Console.WriteLine("Pegando valores digitados no console:");
        Console.WriteLine("Digite seu nome:");
        string valorDigitado = Console.ReadLine();
        
        Console.WriteLine(" ----- ");
        Console.WriteLine("Nome digitado:");
        Console.WriteLine(valorDigitado);
    }
}
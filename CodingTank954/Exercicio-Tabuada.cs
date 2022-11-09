namespace CodingTank954
{
    public class Exercicio_Tabuada
    {
        static void MainExTb(string[] args)
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("*         Tabuada             *");
            Console.WriteLine("*******************************");

            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int num);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }
    }
}

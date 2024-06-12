using System;

class Exemplo03
{
    public static void Main(string[] args)
    {
        {
            Console.WriteLine("Temporizador");
            Console.WriteLine("Informe os Minutos:");
            int minutos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe os Segundos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());

            int totalSegundos = (minutos * 60) + segundos;

            for (int i = totalSegundos; i >= 0; i--)
            {
                int min = i / 60;
                int sec = i % 60;
                Console.Clear();
                Console.WriteLine($"Tempo restante: {min:D2}:{sec:D2}");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Tempo esgotado!");
        }
    }
}
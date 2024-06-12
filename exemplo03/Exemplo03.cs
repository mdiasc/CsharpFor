using System;

class Exemplo03
{
    public static void Main(string[] args)
    {
        {
            Console.WriteLine("Cronômetro Senac");

            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    Console.WriteLine(i + " : " + j);
                }
            }
        }
    }
}
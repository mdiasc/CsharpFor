using System;

class Exemplo01
{
    public static void Main(string[] args)
    {
        int contadora = 0;
        int acumuladora = 0;
        do 
        {
            if (contadora%2==0)
            {
                acumuladora += contadora;
            }
            contadora++;
        }
        while (contadora < 501);
        Console.WriteLine("A somatória dos numeros pares menor que 500 é : " + acumuladora);
    }
}
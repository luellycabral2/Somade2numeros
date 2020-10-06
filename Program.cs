using System;

namespace Somade2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor01 ; 
            int valor02 ;

            Console.WriteLine("Escreva o V01 : ");
            valor01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o V02 :");
            valor02 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine($" Sua conta é: { valor01 + valor02 }");

            Console.WriteLine("click ENTER para sair");
            Console.ReadKey();
            




        }
    }
}

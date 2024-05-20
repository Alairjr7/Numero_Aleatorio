using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinha_Numero_Aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int NumeroAleatorio = random.Next(1,100);
            int NumeroAdivinha;
            int tentativa = 1;
            Boolean ganhou = false;
            
            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("        ADIVINHE O NÚMERO      ");
                Console.WriteLine("-------------------------------");

                Console.Write("Adivinhe um numero de 1 a 100: ");
                NumeroAdivinha = Convert.ToInt32(Console.ReadLine());

                if(NumeroAdivinha > NumeroAleatorio)
                {
                    tentativa++;
                    Console.Write("O número "+NumeroAdivinha+" é MAIOR que o número aleatorio.");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else if(NumeroAdivinha < NumeroAleatorio)
                {
                    tentativa++;
                    Console.Write("O número " + NumeroAdivinha + " é MENOR que o número aleatorio.");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("PARÁRABENS, VOCÊ GANHOU !!!");
                    Console.WriteLine("TENTATIVA(S): " + tentativa);
                    ganhou = true;
                }


            }while (ganhou == false);
        }
    }
}

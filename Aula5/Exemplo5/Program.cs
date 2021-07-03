using System;
using System.Threading;

namespace Exemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1:  ===================================================================================================================
            /*int c;
            Console.WriteLine("A sequencia de 0 a 1000");
            for (c = 0; c <= 1000; c++)
            {
                Console.WriteLine(c);
                Thread.Sleep(2);
            }
            Console.ReadKey();*/

            //Exemplo 2:  ===================================================================================================================
            /*double num, soma, med;
            Console.WriteLine("Digite dez numeros: ");
            soma = 0;
            for (int c = 1; c <= 10; c++)
            {
                Console.Write("Digite o " + c + "º: ");
                num = Convert.ToDouble(Console.ReadLine());
                soma = soma + num;
            }
            med = soma / 10;
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Média: " + med);
            Console.ReadKey();*/

            //Exemplo 3:  ===================================================================================================================
            /*double num, soma, med;
            Console.WriteLine("Digite dez numeros: ");
            soma = 0;
            for (int c = 1; c <= 10; c++)
            {
                Console.Write("Digite o " + c + "º: ");
                num = Convert.ToDouble(Console.ReadLine());
                if (num % 2 == 0)
                {
                    soma = soma + num;
                }
            }
            med = soma / 10;
            Console.WriteLine("Soma dos pares: " + soma);
            Console.WriteLine("Média com a soma dos pares: " + med);
            Console.ReadKey();*/

            //Exemplo 4:  ===================================================================================================================
            /*int num, c, resp;
            c = 0;
            Console.Write("Digite o número da tabuada: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (c <= 10)
            {
                resp = c * num;
                Console.WriteLine(num + " x " + c + " = " + resp);
                Thread.Sleep(100);
                c = c + 1;
            }
            Console.ReadKey();*/

            //Exemplo 5:  ===================================================================================================================
            /*inicio:
            int num;
            Console.Write("Digite um numero: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero: " + num);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor incorreto!");
                Console.ForegroundColor = ConsoleColor.White;
                goto inicio;
            }

            Console.ReadKey();*/

            //Exemplo 6:  ===================================================================================================================
            /*inicio:
            int num;
            Console.Write("Digite um numero: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero: " + num);
            }
            catch (Exception ex)
            {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Valor incorreto!");
               Console.ForegroundColor = ConsoleColor.DarkRed;
               Console.WriteLine(ex);
               Console.ForegroundColor = ConsoleColor.White;
               goto inicio;
            }
            Console.ReadKey();*/

            //Exemplo 7:  ===================================================================================================================
            /*int num;
            Console.Write("Digite um numero: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero: " + num);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor incorreto!");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex);
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                Console.WriteLine("Eric Kida - 1ADS");
            }
            Console.ReadKey();*/

            
        }
    }
}

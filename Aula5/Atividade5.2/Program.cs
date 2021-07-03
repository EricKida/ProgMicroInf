using System;

namespace Atividade5._2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercício 1:  ==================================================================================================================
            /*double n1;
            n1 = 0;
            do
            {
                Console.Write("Digite um número: ");
                n1 = Convert.ToDouble(Console.ReadLine());

            } while (n1 % 2 != 0);
            Console.WriteLine(n1 + " é par.");
            Console.ReadKey();*/

            //Exercício 2:  ==================================================================================================================
            /*double n1, c, total, media, cc;
            total = 0;
            c = 1;
            do
            {
                nota:
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite a "+c+"º nota: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                n1 = Convert.ToDouble(Console.ReadLine());
                if(n1 >= 0 && n1 <= 10)
                {
                    total = total + n1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Somente notas entre 0 e 10");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Para continuar digite 1 e para sair digite qualquer número - ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    cc = Convert.ToDouble(Console.ReadLine());
                    if(cc == 1)
                    {
                        goto nota;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Incapaz de gerar média.");
                        goto fim;
                    }
                }
                c++;
            } while (c <= 4);
            media = total / 4;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Média das notas: ");
            if(media >= 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(media);
            fim:
            Console.ReadKey();*/

            //Exercício 3:  ==================================================================================================================
            /*double n1;
            do
            {
                Console.Write("Digite um valor: ");
                n1 = Convert.ToDouble(Console.ReadLine());

            } while (n1 > 1);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(n1 + " é um dos números secretos!");
            Console.ReadKey();*/

            //Exercício 4:  ==================================================================================================================
            /*double n1 = 0;
            double total = 0;
            do
            {
                total = total + n1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite um valor: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                n1 = Convert.ToDouble(Console.ReadLine());

            } while (n1 != 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Até você encontrar o zero, as somas dos números deram ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(total);
            Console.ReadKey();*/
        }
    }
}

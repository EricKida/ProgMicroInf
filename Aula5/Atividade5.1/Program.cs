using System;
using System.Threading;

namespace Atividade5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR
            //Exercício 1:  ===================================================================================================================
            /*int num, resp;
            Console.Write("Digite o número da tabuada: ");
            Console.ForegroundColor = ConsoleColor.Green;
            num = Convert.ToInt32(Console.ReadLine());
            for (int c = 1; c <= 10; c++)
            {
                resp = c * num;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(num + " x " + c + " = " + resp);
                Thread.Sleep(100);
            }
            Console.ReadKey();*/

            //Exercício 2:  ===================================================================================================================
            /*inicio:
            int n1;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite um valor maior que zero: ");
            Console.ForegroundColor = ConsoleColor.Green;
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 > 0) { 
                for (int c = 1; c <= n1; c++)
                {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(c);
                Thread.Sleep(50);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor incorreto!");
                goto inicio;
            }
            Console.ReadKey();*/

            //Exercício 3:  ===================================================================================================================
            /*double num, soma;
            Console.WriteLine("Digite dez numeros: ");
            soma = 0;
            for (int c = 1; c <= 10; c++)
            {
                Console.Write("Digite o " + c + "º: ");
                num = Convert.ToDouble(Console.ReadLine());
                if (num > 10)
                {
                    soma = soma + num;
                }
            }
            Console.WriteLine("Soma dos maiores que 10: " + soma);
            Console.ReadKey();*/

            //Exercício 4:  ===================================================================================================================
            /*int maior = 0;
            int menor = 0;
            int n = 0;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Infome 20 números");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1º número: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            n = Convert.ToInt32(Console.ReadLine());
            maior = n;
            menor = n;
            double i = 1;
            for (i = 2; i <= 20; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(i + "º número: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                n = Convert.ToInt32(Console.ReadLine());
                if (n < menor)
                {
                    menor = n;
                }
                else if (n > maior)
                {
                    maior = n;
                }
            }
            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Menor número: " + menor);
            Console.ReadKey();*/

            //WHILE
            //Exercício 1:  ===================================================================================================================
            /*inicio:
            double i, f;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Valor incial: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            i = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Valor final: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            f = Convert.ToDouble(Console.ReadLine());
            if (i > f)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Valor INICIAL não pode ser maior que o valor FINAL");
                goto inicio;
            }
            else
            {
            while (i <= f)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
                i = i + 1;
            }
            Console.ReadKey();*/

            //Exercício 2:  ===================================================================================================================
            /*double idade, soma;
            soma = 0;
            int c = 1;
            while (c <= 10)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Idade da "+c+"º pessoa: ");
                Console.ForegroundColor = ConsoleColor.Green;
                idade = Convert.ToDouble(Console.ReadLine());
                if (idade > 18)
                {
                    soma = soma + 1;
                }
                c++;
            }
            Console.Write(soma);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" pessoa(s) possue(m) mais de 18 anos");
            Console.ReadKey();*/

            //Exercício 3:  ===================================================================================================================
            /*double n1, soma;
            soma = 0;
            int c = 1;
            while (c <= 10)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(c+"º valor: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                n1 = Convert.ToDouble(Console.ReadLine());
                if (n1 < 0)
                {
                    soma = soma + 1;
                }
                c++;
            }
            Console.Write(soma);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" desses 10 números são negativos.");
            Console.ReadKey();*/

            //Exercício 4:  ===================================================================================================================
            /*double n1 = 1;
            double n2 = 0;
            while (n1 <= 10)
            {
                n2 = 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(n1 + ", ");
                while (n2 <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.White;  
                    Console.Write(n2 + " ");
                    n2++;
                }
                n1++;
                Console.WriteLine("");
            }
            Console.ReadKey();*/
        }
    }
}

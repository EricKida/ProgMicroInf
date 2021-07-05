using System;

namespace Atividade5._2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercício 1:  ==================================================================================================================FAZE
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
            //Professor, na hora que eu fui fazer esse exercício eu fiz da primeira maneira que está sendo mostrada, porém eu usei "goto" e acho que era
            //pra usar do/while nestes momentos, fora que na prática, a forma da primeira maneira é diferente da segunda. Se essa primeira estiver errada,
            //acho que da segunda maneira está correta kk.

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
            //===============================================================================================================================
            /*double n1, n2, n3, n4, md;
            int cc;
            do
            {
                Console.Clear();
                cc = 0;
                do
                {
                    Console.Write("Digite a 1º Nota: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                } while (n1 < 0 || n1 > 10);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1º Nota aceita: " + n1);
                Console.ForegroundColor = ConsoleColor.White;

                do
                {
                    Console.Write("Digite a 2º Nota: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                } while (n2 < 0 || n2 > 10);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2º Nota aceita: " + n2);
                Console.ForegroundColor = ConsoleColor.White;

                do
                {
                    Console.Write("Digite a 3º Nota: ");
                    n3 = Convert.ToDouble(Console.ReadLine());
                } while (n3 < 0 || n3 > 10);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("3º Nota aceita: " + n3);
                Console.ForegroundColor = ConsoleColor.White;

                do
                {
                    Console.Write("Digite a 4º Nota: ");
                    n4 = Convert.ToDouble(Console.ReadLine());
                } while (n4 < 0 || n4 > 10);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("4º Nota aceita: " + n4);
                Console.ForegroundColor = ConsoleColor.White;

                md = (n1 + n2 + n3 + n4) / 4;
                if (md >= 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("Média final: " + md);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite 1 para continuar e qualquer outro número para sair: ");
                cc = Convert.ToInt32(Console.ReadLine());
            } while (cc == 1);
            //Console.ReadKey();*/

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

using System;

namespace Atividade4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1: 
            /*Console.Title = "Operações"; 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("▓     Escolha uma opção     ▓");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(7, 5);
            Console.WriteLine("1 - Bhaskara");
            Console.SetCursorPosition(7, 6);
            Console.WriteLine("2 - Força");
            Console.SetCursorPosition(7, 7);
            Console.WriteLine("3 - Velocidade");
            Console.SetCursorPosition(25, 5);
            Console.Write("[ ]");
            Console.SetCursorPosition(26, 5);
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓         Bhaskara          ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 12);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Digite o valor de A: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 6);                                                                                                                                                                                                                                                                    
                    Console.Write("Digite o valor de B: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Digite o valor de C: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double delta = Math.Pow(b, 2) - 4 * a * c;
                    if (delta > 0)
                    {
                        double x1 = (-(b) + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-(b) - Math.Sqrt(delta)) / (2 * a);
                        x1 = Math.Round(x1, 2);
                        x2 = Math.Round(x2, 2);
                        Console.SetCursorPosition(14,9);
                        Console.WriteLine("X1: " + x1);
                        Console.SetCursorPosition(14, 10);
                        Console.WriteLine("X2: " + x2);
                    }
                    else
                    {
                        Console.SetCursorPosition(14, 9);
                        Console.WriteLine("Delta <= 0");
                        Console.SetCursorPosition(14, 10);
                        Console.WriteLine("Sem solução");
                    }

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓           Força           ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Digite a massa: ");
                    double m = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Digite a aceleração: ");
                    double ac = Convert.ToDouble(Console.ReadLine());
                    double f = m * ac;
                    Console.SetCursorPosition(15, 8);
                    Console.WriteLine("Força: " + f);

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓         Velocidade        ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Velocidade Incial: ");
                    double vo = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Aceleração: ");
                    double acc = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Tempo: ");
                    double t = Convert.ToDouble(Console.ReadLine());
                    double v = vo + (acc * t);
                    Console.SetCursorPosition(13, 9);
                    Console.WriteLine("Velocidade: " + v);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("N/A");
                    break;
            }
            Console.ReadKey();*/


            //Exercício 2: ====================================================================================================================================
            /*Console.Title = "Calculadora";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("▓   Operações       [ ]     ▓");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 11);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(7, 6);
            Console.WriteLine("1 + Soma");
            Console.SetCursorPosition(7, 7);
            Console.WriteLine("2 * Multiplicação");
            Console.SetCursorPosition(7, 8);
            Console.WriteLine("3 - Subtração");
            Console.SetCursorPosition(7, 9);
            Console.WriteLine("4 / Divisão");
            Console.SetCursorPosition(26, 4);
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓            Soma           ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Primeiro valor: ");
                    double s1 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Segundo valor: ");
                    double s2 = Convert.ToDouble(Console.ReadLine());
                    double soma = s1 + s2;
                    Console.SetCursorPosition(17, 9);
                    Console.Write(s1+"+"+s2+"="+soma);
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓       Multiplicação       ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Primeiro valor: ");
                    double m1 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Segundo valor: ");
                    double m2 = Convert.ToDouble(Console.ReadLine());
                    double mult = m1 * m2;
                    mult = Math.Round(mult, 2);
                    Console.SetCursorPosition(14, 9);
                    Console.Write(m1 + "*" + m2 + "=" + mult);
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓         Subtração         ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Primeiro valor: ");
                    double ss1 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Segundo valor: ");
                    double ss2 = Convert.ToDouble(Console.ReadLine());
                    double subrt = ss1 - ss2;
                    Console.SetCursorPosition(15, 9);
                    Console.Write(ss1 + "-" + ss2 + "=" + subrt);
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓          Divisão          ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 11);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Primeiro valor: ");
                    double d1 = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Segundo valor: ");
                    double d2 = Convert.ToDouble(Console.ReadLine());
                    double div = d1 / d2;
                    div = Math.Round(div, 2);
                    Console.SetCursorPosition(15, 9);
                    Console.Write(d1 + "/" + d2 + "=" + div);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(25, 5);
                    Console.WriteLine("N/A");
                    break;
            }
            Console.ReadKey();*/

            //Exercício 3: ====================================================================================================================================
            /*Console.Title = "Empresa";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("▓     Escolha seu cargo     ▓");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(7, 5);
            Console.WriteLine("1 - Gerente");
            Console.SetCursorPosition(7, 6);
            Console.WriteLine("2 - Analista");
            Console.SetCursorPosition(7, 7);
            Console.WriteLine("3 - Técnico");
            Console.SetCursorPosition(7, 8);
            Console.WriteLine("4 - Outro");
            Console.SetCursorPosition(25, 5);
            Console.Write("[ ]");
            Console.SetCursorPosition(26, 5);
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓          Gerente          ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Salário atual: R$");
                    double g = Convert.ToDouble(Console.ReadLine());
                    double g_porcent = g * 0.1;
                    double g_sal = g + g_porcent;
                    double g_dif = g_sal - g;
                    g_sal = Math.Round(g_sal, 2);
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Novo salário:  R$"+g_sal);
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Diferença:     R$ "+g_dif);


                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓          Analista         ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Salário atual: R$");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double a_porcent = a * 0.2;
                    double a_sal = a + a_porcent;
                    double a_dif = a_sal - a;
                    a_sal = Math.Round(a_sal, 2);
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Novo salário:  R$" + a_sal);
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Diferença:     R$ " + a_dif);

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓          Técnico          ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Salário atual:  R$");
                    double t = Convert.ToDouble(Console.ReadLine());
                    double t_porcent = t * 0.3;
                    double t_sal = t + t_porcent;
                    double t_dif = t_sal - t;
                    t_sal = Math.Round(t_sal, 2);
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Novo salário:   R$" + t_sal);
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Diferença:      R$ " + t_dif);
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("▓           Outro           ▓");
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("▓                           ▓");
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Salário atual: R$");
                    double o = Convert.ToDouble(Console.ReadLine());
                    double o_porcent = o * 0.4;
                    double o_sal = o + o_porcent;
                    double o_dif = o_sal - o;
                    o_sal = Math.Round(o_sal, 2);
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Novo salário:  R$" + o_sal);
                    Console.SetCursorPosition(7, 7);
                    Console.Write("Diferença:     R$ " + o_dif);

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("N/A");
                    break;
            }
            Console.ReadKey();*/
        }
    }
}

using System;

namespace Prova
{
    class Program
    {
        static void moldura()
        {
            Console.Title = "AVALIAÇÃO DE PROGRAMAÇÃO EM MICROINFORMÁTICA - ERIC KIDA - 1ADS VESP";
            int c = 2;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(5, c);
            Console.WriteLine("┌══════════════════════════════════════════┐");
            for (c = 3; c <= 11; c++)
            {
            Console.SetCursorPosition(5, c); 
            Console.WriteLine("║                                          ║");
            }
            Console.SetCursorPosition(5, c);
            Console.WriteLine("├══════════════════════════════════════════┤");
            Console.SetCursorPosition(5, c+1);
            Console.WriteLine("│Nome: Eric Kida Meneses Corrêa - 1ADS VESP│");
            Console.SetCursorPosition(5, c+2);
            Console.WriteLine("└══════════════════════════════════════════┘");
        }
        static void menu()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(15, 3);
            Console.WriteLine("■█ Escolha uma opção █■");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("├══════════════════════════════════════════┤");
        }
        static void op1()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(18, 3);
            Console.WriteLine("■█ Ano Bissexto █■");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("├══════════════════════════════════════════┤");
        }
        static void op2()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(19, 3);
            Console.WriteLine("■█ Calorimetria █■");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("├══════════════════════════════════════════┤");
        }
        static void op3()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(14, 3);
            Console.WriteLine("■█ Resistência Elétrica █■");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("├══════════════════════════════════════════┤");
        }

        static void Main(string[] args)
        {
        double cc = 1;
            do
            {
            inicio:
            moldura();
            menu();
            
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(7, 6);
                Console.Write("1 - ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ano Bissexto");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(7, 8);
                Console.Write("2 - ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Calorimetria");


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(7, 10);
                Console.Write("3 - ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Resistência Elétrica");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(40, 8);
                Console.Write("[   ]");
                Console.SetCursorPosition(42, 8);
                Console.ForegroundColor = ConsoleColor.White;
                double op = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                if (op == 1)
                {
                    moldura();
                    op1();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Digite o ano: ");
                    Console.SetCursorPosition(7, 6);
                    Console.Write("»");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(9, 6);
                    double anB = Convert.ToDouble(Console.ReadLine());
                    if (((anB % 400) == 0) || (anB % 4 == 0 && anB % 100 != 0))
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(9, 8);
                        Console.Write(anB);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" é um ano bissexto.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(9, 8);
                        Console.Write(anB);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" não é um ano bissexto.");
                    }

                }
                else if (op == 2)
                {
                    moldura();
                    op2();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Informe:");
                    Console.SetCursorPosition(7, 6);
                    Console.Write("Massa(m) »");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(18, 6);
                    double m = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Calor(c) »");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(18, 7);
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(7, 8);
                    Console.Write("Variação temperatura(deltaT) »");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(38, 8);
                    double t = Convert.ToDouble(Console.ReadLine());
                    double calor = m * c * t;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(7, 9);
                    Console.Write("Quantidade de calor: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(calor + "º");
                }
                else if (op == 3)
                {
                    moldura();
                    op3();
                op3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(7, 5);
                    Console.Write("Você quer descobrir: ");
                    Console.SetCursorPosition(7, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("1 - ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("U - Tensão ou Potencial Elétrico (v)");
                    Console.SetCursorPosition(7, 7);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("2 - ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("I - Corrente elétrica");
                    Console.SetCursorPosition(7, 8);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("3 - ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("R - Resistência elétrica");
                    Console.SetCursorPosition(25, 9);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[   ]");
                    Console.SetCursorPosition(27, 9);
                    Console.ForegroundColor = ConsoleColor.White;
                    double opp3 = Convert.ToDouble(Console.ReadLine());
                    if (opp3 == 1)
                    {
                        Console.Clear();
                        moldura();
                        op3();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(7, 5);
                        Console.Write("Informe:");
                        Console.SetCursorPosition(7, 6);
                        Console.Write("Resistência elétrica(r) »");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(33, 6);
                        double r = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(7, 7);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Corrente elétrica(i) »");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(30, 7);
                        double i = Convert.ToDouble(Console.ReadLine());
                        double tensao = r * i;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(7, 9);
                        Console.Write("Potencial elétrico: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(tensao + "v");
                    }
                    else if (opp3 == 2)
                    {
                        Console.Clear();
                        moldura();
                        op3();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(7, 5);
                        Console.Write("Informe:");
                        Console.SetCursorPosition(7, 6);
                        Console.Write("Tensão(u) »");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(19, 6);
                        double u = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(7, 7);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Resistência elétrica(r) »");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(33, 7);
                        double r = Convert.ToDouble(Console.ReadLine());
                        double corrente = u / r;
                        corrente = Math.Round(corrente, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(7, 9);
                        Console.Write("Corrente elétrica: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(corrente+"A");
                    }
                    else if (opp3 == 3)
                    {
                        Console.Clear();
                        moldura();
                        op3();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(7, 5);
                        Console.Write("Informe:");
                        Console.SetCursorPosition(7, 6);
                        Console.Write("Tensão(u) »");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(19, 6);
                        double u = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(7, 7);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Intensidade elétrica(i) »");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(33, 7);
                        double i = Convert.ToDouble(Console.ReadLine());
                        double resist = u / i;
                        resist = Math.Round(resist, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(7, 9);
                        Console.Write("Corrente elétrica: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(resist+" Ohms");
                    }
                    else
                    {
                        Console.Clear();
                        moldura();
                        op3();
                        goto op3;
                    }
                }
                else
                {
                    goto inicio;
                }
                Console.SetCursorPosition(7, 11);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Para voltar digite 1: [   ]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(31, 11);
                cc = Convert.ToDouble(Console.ReadLine());
            } while (cc == 1);
        }
    }
}

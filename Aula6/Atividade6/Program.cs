using System;

//Exercício 1 ========================================================================================================================================================================
/* namespace Ex1TF9
{
    class Program
    {
        static void moldura()
        {
            int c = 2;
            Console.SetCursorPosition(5, c);
            Console.WriteLine("████████████████████████████████████");
            for (c = 3; c <= 9; c++)
            {
                Console.SetCursorPosition(5, c);
                Console.WriteLine("█                                  █");
            }
            Console.SetCursorPosition(5, c);
            Console.WriteLine("████████████████████████████████████");
        }
        static double add(double n1, double n2)
        {
            double r = (n1 + n2);
            return r;
        }

        static double sub(double n1, double n2)
        {
            double r = (n1 - n2);
            return r;
        }

        static double mult(double n1, double n2)
        {
            double r = (n1 * n2);
            return r;
        }

        static double div(double n1, double n2)
        {
            double r = (n1 / n2);
            return r;
        }

        static void Main(string[] args)
        {
            double rep = 1;
            Console.Title = "Calculadora";
            do
            {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            moldura();
            Console.SetCursorPosition(7, 4);
            Console.Write("Deseja qual operação? ");
            Console.SetCursorPosition(7, 5);
            Console.Write("1 - Adição");
            Console.SetCursorPosition(7, 6);
            Console.Write("2 - Subtração");
            Console.SetCursorPosition(7, 7);
            Console.Write("3 - Multiplicação");
            Console.SetCursorPosition(7, 8);
            Console.Write("4 - Divisão");
            Console.SetCursorPosition(30, 4);
            Console.Write("[   ]");
            Console.SetCursorPosition(32, 4);
            double op = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

                if (op == 1)
                {
                    rep++;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    moldura();
                    Console.SetCursorPosition(19, 4);
                    Console.Write("ADIÇÃO");
                    Console.SetCursorPosition(7, 6);
                    Console.Write("1º Valor: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("2º Valor: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 8);
                    Console.Write(a+" + "+b+" = " + add(a, b));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("Menu = 1");
                    Console.SetCursorPosition(27, 7);
                    Console.WriteLine("[   ]");
                    Console.SetCursorPosition(29, 7);
                    rep = Convert.ToDouble(Console.ReadLine());
                }
                else if (op == 2)
                {
                    rep++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    moldura();
                    Console.SetCursorPosition(18, 4);
                    Console.Write("SUBTRAÇÃO");
                    Console.SetCursorPosition(7, 6);
                    Console.Write("1º Valor: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("2º Valor: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 8);
                    Console.Write(a + " - " + b + " = " + sub(a, b));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("Menu = 1");
                    Console.SetCursorPosition(27, 7);
                    Console.WriteLine("[   ]");
                    Console.SetCursorPosition(29, 7);
                    rep = Convert.ToDouble(Console.ReadLine());
                }
                else if (op == 3)
                {
                    rep++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    moldura();
                    Console.SetCursorPosition(16, 4);
                    Console.Write("MULTIPLICAÇÃO");
                    Console.SetCursorPosition(7, 6);
                    Console.Write("1º Valor: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("2º Valor: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 8);
                    Console.Write(a + " * " + b + " = " + mult(a, b));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("Menu = 1");
                    Console.SetCursorPosition(27, 7);
                    Console.WriteLine("[   ]");
                    Console.SetCursorPosition(29, 7);
                    rep = Convert.ToDouble(Console.ReadLine());
                }
                else if (op == 4)
                {
                    rep++;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    moldura();
                    Console.SetCursorPosition(19, 4);
                    Console.Write("DIVISÃO");
                    Console.SetCursorPosition(7, 6);
                    Console.Write("1º Valor: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 7);
                    Console.Write("2º Valor: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(7, 8);
                    Console.Write(a + " / " + b + " = " + div(a, b));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(25, 6);
                    Console.WriteLine("Menu = 1");
                    Console.SetCursorPosition(27, 7);
                    Console.WriteLine("[   ]");
                    Console.SetCursorPosition(29, 7);
                    rep = Convert.ToDouble(Console.ReadLine());

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    moldura();
                    Console.SetCursorPosition(17, 4);
                    Console.Write("* INVÁLIDO *");
                    Console.SetCursorPosition(13, 5);
                    Console.WriteLine("Para voltar digite '1'");
                    Console.SetCursorPosition(21, 6);
                    Console.WriteLine("[   ]");
                    Console.SetCursorPosition(23, 6);
                    rep = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                }

            } while (rep == 1);
            Console.ReadKey();
        }
    }
}*/

//Exercício 2 ========================================================================================================================================================================
namespace Ex2TF9
{
    class Program
    {
        static double triA(double n1, double n2, double n3)
        {
            double r = 0;
            if(n1+n2 > n3)
            {
                r = 1;
            }
            else
            {
                r = 0;
            }
            return r;
        }

        static void Main(string[] args)
        {
            Console.Title = "Triângulo";
            Console.Write("Primeiro segmento do triângulo: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo segmento do triângulo: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Terceiro segmento do triângulo: ");
            double c= Convert.ToDouble(Console.ReadLine());
            if(triA(a, b, c) == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("As medidas podem formar um triângulo");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("As medidas não podem formar um triângulo");
            }
            Console.ReadKey();
        }
    }
}



using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1:
            /*Console.Title = "Exercício 1 - Quanto você ganha?";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.SetCursorPosition(2, 3);   
            Console.WriteLine("║                                       ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                                       ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                                       ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                                       ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("║                                       ║");
            Console.SetCursorPosition(2, 8);   
            Console.WriteLine("║                                       ║");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("╚═══════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 4);
            Console.Write("Salário mínimo atual R$: ");
            double sm = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(4, 5);
            Console.Write("Insira seu salário R$: ");
            double sd = Convert.ToDouble(Console.ReadLine());
            double sf = sd / sm;
            sf = Math.Round(sf,2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("Você ganha ");
            Console.SetCursorPosition(15, 7);

            if (sf > 0.99) { 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(sf);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(sf);
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" salário(s) mínimo(s).");
            Console.ReadKey();*/

            //Exercício 2:
            /*Console.Title = "Exercício 2 - Cº -> Kº";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔═════════════════º═══════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                                 ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                                 ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                                 ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                                 ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("╚═════════════════º═══════════════╝");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(4, 4);
            Console.Write("Temperatura em Celsius: ");
            double tc = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(4, 5);
            double tk = tc+273.15;
            tk = Math.Round(tk, 2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("Temperatura em Kelvin: "+tk);
            Console.ReadKey();*/


            //Exercício 3:
            /*Console.Title = "Exercício 3 - Fº -> Cº";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(4, 4);
            Console.Write("Temperatura em Fahrenheit: ");
            double tf = Convert.ToDouble(Console.ReadLine());
            double tc = (tf-32)*5/9;
            tc = Math.Round(tc, 2);

            if (tc > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(4, 5);
                Console.WriteLine("Temperatura em Celsius: " + tc);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(4, 5);
                Console.WriteLine("Temperatura em Celsius: " + tc);
            }
            Console.ReadKey();*/

            //Exercício 4:
            /*Console.Title = "Exercício 4 - Qual seu peso?";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔══════════════════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("╚══════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 4);
            Console.Write("Peso em Kg: ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(4, 5);
            double pgr = kg * 1000;
            double pac = kg / 100 * 10;
            pac = pac + kg;
            pac = Math.Round(pac, 2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("Peso: " + pgr + " gramas.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("Acréscimo de 10%: " + pac + "kg.");
            Console.ReadKey();*/

            //Exercício 5:
            /*Console.Title = "Exercício 5 - >20 = Metade ou <20 = Dobro";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(4, 4);
            Console.Write("Digite um valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            if (n1 > 20) {
                n1 = n1 / 2;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                n1 = n1 * 2;
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            Console.SetCursorPosition(4, 5);
            Console.Write("Valor final: "+n1);
            Console.ReadKey();*/

            //Exercício 6:
            /*Console.Title = "Exercício 6 - Multiplo de 5?";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔═════════════════════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                             ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                             ║");
            Console.SetCursorPosition(2, 5);  
            Console.WriteLine("║                             ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                             ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("╚═════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(4, 4);
            Console.Write("Insira um valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(4, 5);
            if (n1%5==0) {
                double n2 = n1 / 5;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("5*"+ n2+"="+n1+" - É multiplo de 5");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(n1 + " não é múltiplo de 5");
            }
            Console.ReadKey();*/

            //Exercício 7:
            /*Console.Title = "Exercício 7 = Empréstimo da prefeitura.com";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔═══════════════════════════════════════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("║                                               ║");
            Console.SetCursorPosition(2, 10);
            Console.WriteLine("╚═══════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(4, 4);
            Console.Write("Seu salário - R$: ");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(4, 5);
            Console.Write("Valor do empréstimo - R$: ");
            double emp = Convert.ToDouble(Console.ReadLine());
            double vsal = sal / 100 * 30;
            if (emp > vsal) { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(6, 7);
                Console.Write("Empréstimo é maior que 30% do seu salário");
                Console.SetCursorPosition(14, 8);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("EMPRESTIMO NÃO CONFIRMADO");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(4, 7);
                Console.Write("Empréstimo não é maior que 30% do seu salário");
                Console.SetCursorPosition(15, 8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("EMPRESTIMO CONFIRMADO");
            }
            Console.ReadKey();*/

            //Exercício 8:
            /*Console.Title = "Positivo, negativo ou zero";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔══════════════════════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                              ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                              ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                              ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                              ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("╚══════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(4, 4);
            Console.Write("Insira um valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(4, 5);
            if (n1 > 0) { 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(n1 + " é um número positivo");
            }
            else if(n1 < 0) { 
            
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(n1 + " é um número negativo");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(n1 + " é zero apenas.");
            }
            
            Console.ReadKey();*/
        }
    }
}

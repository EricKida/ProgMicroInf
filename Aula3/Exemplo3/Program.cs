using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.Title = "Exemplo Idade";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
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
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 10);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 11);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(12, 3);
            Console.WriteLine("FATEC 2021 - ADS");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(4, 5);
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.SetCursorPosition(4, 6);
            Console.Write("Insira sua idade: ");
            double idade = Convert.ToDouble(Console.ReadLine());
            if (idade % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(6, 8);
                Console.WriteLine("Seu nome é " + nome);
                Console.SetCursorPosition(6, 9);
                Console.WriteLine("e sua idade de "+idade+" anos é par");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(6, 8);
                Console.WriteLine("Seu nome é " + nome);
                Console.SetCursorPosition(6, 9);
                Console.WriteLine("e sua idade de " + idade + " anos é impar");
            }

            Console.ReadKey();
        }//fim
    }
}

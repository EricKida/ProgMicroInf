using System;

namespace Exemplo4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exemplo 1:
            /*Console.Title = "Operadores Lógicos";
            Console.Write("Digite um número par positivo: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            if ((n1>0) && (n1 % 2 == 0))
            {
                Console.WriteLine(n1 + " é um número par positivo.");
            }
            else
            {
                Console.WriteLine(n1 + " não obecede as ordens.");
            }
            Console.ReadKey();*/

            //Exemplo 2:
            /*Console.Title = "Passou de ano?";
            Console.Write("Digite sua primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua terceira nota: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua quarta nota: ");
            double n4 = Convert.ToDouble(Console.ReadLine());
            double m = (n1 + n2 + n3 + n4) / 4;
            if (m > 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Média: " + m + " - Aprovado meu camarada :D");
            }
            else if((m>=3) && (m < 5)){
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Média: " + m + " - Fico de recuperação meu mano :|");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Média: "+m+" - Reprovado meu amigo :(");
            }
            Console.ReadKey();*/

            //Exemplo 3:
            /*Console.Title = "Menu de opções";
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite sua opção: ");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (op)
            {
                case 1:
                    Console.WriteLine("Opção Selecionada: 1 - Soma");
                    Console.Write("Digite o primeiro número: ");
                    double s1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double s2 = Convert.ToDouble(Console.ReadLine());
                    double soma_f = s1 + s2;
                    Console.WriteLine(s1+"+"+s2+" = "+soma_f);
                    break;
                case 2:
                    Console.WriteLine("Opção Selecionada: 2 - Subtração");
                    Console.Write("Digite o primeiro número: ");
                    double ss1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double ss2 = Convert.ToDouble(Console.ReadLine());
                    double sub_f = ss1 - ss2;
                    Console.WriteLine(ss1 + "-" + ss2 + " = " + sub_f);
                    break;
                case 3:
                    Console.WriteLine("Opção Selecionada: 3 - Multiplicação");
                    Console.Write("Digite o primeiro número: ");
                    double m1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double m2 = Convert.ToDouble(Console.ReadLine());
                    double mult_f = m1 * m2;
                    Console.WriteLine(m1 + "*" + m2 + " = " + mult_f);
                    break;
                case 4:
                    Console.WriteLine("Opção Selecionada: 4 - Divisão");
                    Console.Write("Digite o primeiro número: ");
                    double d1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double d2 = Convert.ToDouble(Console.ReadLine());
                    double div_f = d1 / d2;
                    Console.WriteLine(d1 + "/" + d2 + " = " + div_f);
                    break;
            }


            Console.ReadKey();*/
        }
    }
}

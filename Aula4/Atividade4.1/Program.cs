using System;

namespace Atividade4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1 ====================================================================================================================================
            /*Console.Title = "Valor de vendas no mês";
            Console.Write("Digite sua renda total do mês: R$ ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Premiação: ");
            if (n1 < 1000)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Sem premiação");
            }
            else if((n1 >= 1000) && (n1<3000))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("R$ 150,00");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("R$ 300,00");
            }
            Console.ReadKey();*/

            //Exercício 2 ====================================================================================================================================
            /*Console.Title = "É múltiplo de 3 e 7?";
            Console.Write("Digite um valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            if ((n1 % 3 == 0) && (n1 % 7 == 0))
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("É múltiplo de 3 e 7");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Não é múltiplo de 3 e 7");
            }
            Console.ReadKey();*/

            //Exercício 3 ====================================================================================================================================
            /*Console.Title = "Produtos";
            Console.Write("Nome do Produto: ");
            string nme = Console.ReadLine();
            Console.Write("Quantidade de "+nme+": ");
            double qnt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Preço unitário de "+nme+": R$ ");
            double vl = Convert.ToDouble(Console.ReadLine());
            double vltotal = qnt * vl;
            
            if (qnt <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Valor total: R$"+vltotal);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Desconto de 2%");
                double desc = vltotal * 0.02;
                double desctotal = vltotal - desc;
                Console.WriteLine("Valor Total a pagar: R$ "+desctotal);
            }
            else if((qnt > 5) && (qnt <= 10))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Valor total: R$" + vltotal);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Desconto de 3%");
                double desc = vltotal * 0.03;
                double desctotal = vltotal - desc;
                Console.WriteLine("Valor Total a pagar: R$ " + desctotal);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor total: R$" + vltotal);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Desconto de 5%");
                double desc = vltotal * 0.05;
                double desctotal = vltotal - desc;
                Console.WriteLine("Valor Total a pagar: R$ " + desctotal);
            }

            Console.ReadKey();*/

            //Exercício 4 ====================================================================================================================================
            /*Console.Title = "Notas";
            Console.Write("Nota AP: "); 
            double n1 = Convert.ToDouble(Console.ReadLine()); // 25%
            Console.Write("Nota TP: "); 
            double n2 = Convert.ToDouble(Console.ReadLine()); // 25%
            Console.Write("Nota P: "); 
            double n3 = Convert.ToDouble(Console.ReadLine()); // 50%

            double f1 = n1 * 0.25;
            double f2 = n2 * 0.25;
            double f3 = n3 * 0.5;
            double nf = f1 + f2 + f3;

            if(nf >= 9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nota Final: " + nf);
                Console.WriteLine("Conceito D");
            }
            else if((nf >= 7.5) && (nf < 9))
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Nota Final: " + nf);
                Console.WriteLine("Conceito D");
            }
            else if ((nf >= 6) && (nf < 7.5))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nota Final: " + nf);
                Console.WriteLine("Conceito D");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nota Final: " + nf);
                Console.WriteLine("Conceito D");
            }
            Console.ReadKey();*/
        }
    }
}

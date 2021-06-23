using System;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio

            //Exemplo 1: Fazendo a raiz quadrada e elevado ao quadrado algum número n1
            /*double n1, raiz, quadrado;
            Console.Write("Digite um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            raiz = Math.Sqrt(n1);
            quadrado = Math.Pow(n1, 2);
            Console.WriteLine("A raiz de " + n1 + " é " + raiz + ", equanto o quadrado deste mesmo número é " + quadrado);
            Console.ReadKey();*/

            //Exemplo 2: Funções Alfanuméricas
            string nome, nome_ma, nome_mi, nome_corte, nome_sub, nome_esp;
            int pos;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            nome_ma = nome.ToUpper();
            nome_mi = nome.ToLower();
            pos = nome_mi.IndexOf("c");
            nome_corte = nome.Substring(2, 5);
            nome_sub = nome_mi.Replace("a", "o");
            nome_esp = nome_ma.Trim();
            Console.WriteLine("Seu nome em maiúsculo: " + nome_ma);
            Console.WriteLine("Seu nome em minúsculo: " + nome_mi);
            Console.WriteLine("A posição do c é: " + pos);
            Console.WriteLine("Parte do nome: " + nome_corte);
            Console.WriteLine("Trocar o a pelo o: " + nome_sub);
            Console.WriteLine("Tirando o espaço: " + nome_esp);
            Console.ReadKey();
            //Fim
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            /*double r, a, d, p;
            Console.Write("Digite o raio do círculo: ");
            r = Convert.ToDouble(Console.ReadLine());
            // Area
            a = Math.PI * Math.Pow(r, 2);
            a = Math.Round(a, 2);
            // Diametro
            d = 2 * r;
            // Perímetro
            p = 2 * Math.PI * r;
            p = Math.Round(p, 2);
            Console.WriteLine("Área: " + a);
            Console.WriteLine("Diametro: " + d);
            Console.WriteLine("Perímetro: " + p);
            Console.ReadKey();*/

            // Exercício 2
            /*double a, b, c, delta, x1, x2;
            Console.Write("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-(b) + Math.Sqrt(delta)) / (2 * a);
                x2 = (-(b) - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Valor de x1: " + x1);
                Console.WriteLine("Valor de x2: " + x2);
            }
            else
            {
                Console.WriteLine("Não existe valor X1 e X2 pois o delta é negativo ou é igual a 0");
            }
            Console.ReadKey();*/

            //Exercício 3
            /*string completo, nome_substring, nome_replace, nome, sobrenome;
            int espaco;
            Console.Write("Digite seu nome inteiro: ");
            completo = Console.ReadLine();
            espaco = completo.IndexOf(" ");
            nome = completo.Substring(0, espaco);
            sobrenome = completo.Substring(espaco);
            sobrenome = sobrenome.Trim();
            nome_substring = completo.Substring(5, 10);
            nome_replace = completo.Replace("a", "o");
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Seu sobrenome é: " + sobrenome);
            Console.WriteLine("5 a 10 letra fica: " + nome_substring);
            Console.WriteLine("Trocando todas as letras 'a' por 'o' fica: " + nome_replace);
            Console.ReadKey();*/

            //Exercício 4
            /*string nome, nm, email, corte;
            int espaco;
            Console.Write("Digite seu nome inteiro: ");
            nome = Console.ReadLine();
            espaco = nome.IndexOf(" ");
            nm = nome.ToLower();
            corte = nm.Substring(0, espaco);
            email = corte + "@fatec.sp.gov.br";
            Console.WriteLine("Seu email é: " + email);
            Console.ReadKey();*/

            //Exercício 5
            /*string nome_c, nome, sobrenome, email;
            Console.Write("Digite seu nome inteiro: ");
            nome_c = Console.ReadLine();
            string[] espaco = nome_c.Split(' ');
            nome = espaco[0];
            sobrenome = espaco[espaco.Length - 1];
            nome = nome.ToLower();
            sobrenome = sobrenome.ToLower();
            email = nome + "." + sobrenome + "@fatec.sp.gov.br";
            Console.WriteLine("Seu email é: " + email);
            Console.ReadKey();*/
        }
    }
}

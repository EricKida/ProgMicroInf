using System;

namespace Atividades1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio
            //Exercício 1
            /*string nome;
            Console.Write("Digite o nome do usuário: ");
            nome = Console.ReadLine();
            Console.WriteLine("Nome do usuário: "+nome);
            Console.ReadKey();*/

            //Exercício 2
            /*double n1, n2, adicao, subtracao, divisao, multiplicacao;
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            adicao = n1 + n2;
            subtracao = n1 - n2;
            divisao = n1 / n2;
            divisao = Math.Round(divisao, 2);
            multiplicacao = n1 * n2;
            multiplicacao = Math.Round(multiplicacao, 2);
            Console.WriteLine("================================");
            Console.WriteLine(n1 + "+" + n2 + " é: " + adicao);
            Console.WriteLine(n1 + "-" + n2 + " é: " + subtracao);
            Console.WriteLine(n1 + "/" + n2 + " é: " + divisao);
            Console.WriteLine(n1 + "*" + n2 + " é: " + multiplicacao);
            Console.ReadKey();*/

            //Exercício 3
            /*string nome;
            double ano, ano_atual, idade;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Seu ano de nascimento: ");
            ano = Convert.ToDouble(Console.ReadLine());
            Console.Write("Em que ano estamos? ");
            ano_atual = Convert.ToDouble(Console.ReadLine());
            idade = ano_atual - ano;
            Console.WriteLine("A idade de "+nome+" até o final de "+ano_atual+" é de "+idade+ " anos");
            Console.ReadKey();*/

            //Exercício 4
            /*double n1, n2, n3, r;
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            r = (n1 + n2 + n3) / 3;
            r = Math.Round(r, 2);
            Console.WriteLine("A média aritmética de "+n1+ ", " + n2 + " e " + n3 + " é de: " + r);
            Console.ReadKey(); */

            //Exercício 5
            /*double n1, r;
            Console.Write("Digite um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            r = n1 - 1;
            Console.WriteLine("O valor antecessor de "+n1+" é "+r);
            Console.ReadKey();*/

            //Exercício 6
            /*double b, h, a;
            Console.Write("Digite a base do Retângulo: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura do Retângulo: ");
            h = Convert.ToDouble(Console.ReadLine());
            a = b * h;
            Console.WriteLine("A área do retângulo é de: " + a);
            Console.ReadKey();*/

            //Exercício 7
            /*double  dia, mes, ano, r;
            Console.Write("Digite o ano: ");
            ano = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o mês: ");
            mes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o dia: ");
            dia = Convert.ToDouble(Console.ReadLine());
            r = dia + (mes * 30) + (ano * 365);
            Console.WriteLine("A quantidade de dias em "+ano+" anos, "+mes+" meses e "+dia+" dias é "+ r +" dias");
            Console.ReadKey();*/

            //Exercício 8
            /*double n1, n2, n3, mf1, mf2, mf3, m, mf;
            string aluno;
            Console.Write("Nome do aluno: ");
            aluno = Console.ReadLine();
            Console.Write("Nota 1 (Peso 2) do "+aluno+": ");
            n1 = Convert.ToDouble(Console.ReadLine());
            mf1 = n1 * 2;
            Console.Write("Nota 1 (Peso 3) do " + aluno + ": ");
            n2 = Convert.ToDouble(Console.ReadLine());
            mf2 = n2 * 3;
            Console.Write("Nota 1 (Peso 5) do " + aluno + ": ");
            n3 = Convert.ToDouble(Console.ReadLine());
            mf3 = n3 * 5;
            m = mf1 + mf2 + mf3;
            mf = m / 10;
            Console.WriteLine("A média final de " + aluno + " é de "+mf);
            Console.ReadKey();*/

            //fim
        }
    }
}

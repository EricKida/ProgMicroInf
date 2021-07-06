using System;

//Exemplo 1: ======================================================================================================================== - Moldura
/*namespace ConsoleApp5
{
    class Program
    {
        static void mold()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            int c = 2;
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            for (c = 3; c <= 8; c++)
            {
                Console.SetCursorPosition(5, c);
                Console.WriteLine("▒                        ▒");
            }
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }

        static void Main(string[] args)
        {//inicio
            mold();
            Console.ReadKey();
        }//fim
    }
}*/

//Exemplo 2: ======================================================================================================================== - DoubleRetorn
/*namespace ConsoleApp5
{
    class Program
    {
        static void mold() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            int c = 2;
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            for (c = 3; c <= 7; c++) {
                Console.SetCursorPosition(5, c);
                Console.WriteLine("▒                                    ▒");
            }
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }
        static double tempM(double n1, double n2) {
            double r = (n1 + n2)/2;
            return r;
        }

        static void Main(string[] args)
        {//inicio
            Console.Title = "Função";
            mold();
            Console.SetCursorPosition(7, 4);
            Console.Write("Entre com a temperatura 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(7, 5);
            Console.Write("Entre com a temperatura 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(7, 6);
            Console.Write("Média da temperatura: "+tempM(a,b));
            Console.ReadKey();
        }//fim
    }
 }*/

//Exemplo 3: ======================================================================================================================== - IntRetorn
/*namespace ConsoleApp5
{
    class Program
    {
        static void mold()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            int c = 2;
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            for (c = 3; c <= 7; c++)
            {
                Console.SetCursorPosition(5, c);
                Console.WriteLine("▒                                    ▒");
            }
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }
        static int soma(int n1, int n2)
        {
            int r = n1 + n2;
            return r;
        }

        static void Main(string[] args)
        {//inicio
            Console.Title = "Função";
            mold();
            Console.SetCursorPosition(7, 4);
            Console.Write("Entre com o primeiro valor: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(7, 5);
            Console.Write("Entre com o segundo valor: ");
            int b = Convert.ToInt32(Console.ReadLine());
            //int resultado = soma(a, b);
            Console.SetCursorPosition(7, 6);
            Console.Write("Resultado: " + soma(a, b));
            Console.ReadKey();
        }//fim
    }
}*/

//Exemplo 4: ======================================================================================================================== - IntRetorn
/*namespace ConsoleApp5
{
    class Program
    {
        static void mold()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            int c = 2;
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            for (c = 3; c <= 8; c++)
            {
                Console.SetCursorPosition(5, c);
                Console.WriteLine("▒                                    ▒");
            }
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }
        static int subtracao(int n1, int n2)
        {
            int r = n1 - n2;
            Console.SetCursorPosition(7, 7);
            Console.WriteLine("Resultado: " + r);
            return 0;
        }

        static void Main(string[] args)
        {//inicio
            Console.Title = "Função";
            mold();
            Console.SetCursorPosition(7, 4);
            Console.Write("Entre com o primeiro numero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(7, 5);
            Console.Write("Entre com o segundo numero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            subtracao(a, b);
            Console.ReadKey();
        }//fim
    }
}*/

//Exemplo 5: ======================================================================================================================== - ForIntRetorn
/*namespace ConsoleApp5
{
    class Program
    {
        static void mold()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            int c = 2;
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            for (c = 3; c <= 20; c++)
            {
                Console.SetCursorPosition(5, c);
                Console.WriteLine("▒                                    ▒");
            }
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }
        static int tab(int n1, int n2)
        {
            for (int c = 0; c <= n2; c++)
            {
                int r = n1 * c;
                Console.SetCursorPosition(7, c + 6);
                Console.WriteLine(n1 + " x " + c + " = " + r);

            }
            return 0;
        }

        static void Main(string[] args)
        {//inicio
            Console.Title = "Função";
            mold();
            Console.SetCursorPosition(7, 4);
            Console.Write("Entre o valor da tabuada: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(7, 5);
            Console.Write("Tabuada até qual numero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            tab(a, b);
            Console.ReadKey();
        }//fim
    }
}*/
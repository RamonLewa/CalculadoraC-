using System.Runtime.CompilerServices;

namespace CalculadoraC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora C#\n");

            Console.WriteLine("Operações:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão\n");

            Console.Write("Qual operação deseja realizar? ");
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            string op = "";

            switch (operacao)
            {
                case 1: resultado = Adicao(num1, num2);
                    op = "adição";
                    break;

                case 2: resultado = Subtracao(num1, num2);
                    op = "subtração";
                    break;

                case 3: resultado = Multiplicacao(num1, num2);
                    op = "multiplicação";
                    break;

                case 4: resultado = Divisao(num1, num2);
                    op = "divisão";
                    break;

                default: Console.WriteLine("Operação inválida!");
                    break;
            }

            Console.WriteLine($"O resultado da operação {op} com os números {num1} e {num2} é: {resultado}");
        }

        public static double Adicao(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }

        public static double Subtracao(double num1, double num2) 
        {
            double resultado = num1 - num2;
            return resultado;
        }

        public static double Multiplicacao(double num1, double num2) 
        {
            double resultado = num1 * num2;
            return resultado;
        }

        public static double Divisao(double num1, double num2)
        {
            double resultado = num1 / num2;
            return resultado;
}
    }
}

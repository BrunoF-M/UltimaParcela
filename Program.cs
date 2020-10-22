using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double valor;
            double parcelas;

            DateTime data = new DateTime(2020, 05, 13);

            Console.Write("digite o valor a ser Pago...........: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("parcelas totais do financiamento....: ");
            parcelas = double.Parse(Console.ReadLine());

            Console.WriteLine();

            int parcelas2 = Convert.ToInt32(parcelas);
            DateTime data2 = data.AddMonths(parcelas2);
            string data21 = data2.ToShortDateString();
            double total = (valor / parcelas2);

            Console.ForegroundColor=ConsoleColor.DarkGreen;

            Console.Write($"Sua última parcela será em {data21}, no valor de: {total}");

            Console.WriteLine();
            Console.WriteLine();

            Console.ResetColor();
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

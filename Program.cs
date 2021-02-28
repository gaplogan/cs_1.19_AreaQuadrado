using System;

namespace cs_1._19_AreaQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            double lado, area;

            // Entrada de dados
            Console.Write("Digite o valor do lado do quadrado: ");
            lado = double.Parse(Console.ReadLine());

            // Processamento de dados
            lado = Math.Abs(lado); //garante lado positivo
            area = lado * lado; //fórmula da área do quadrado

            // Saída de dados
            Console.WriteLine();
            Console.WriteLine($"Área do quadrado: {area}");    
        }
    }
}

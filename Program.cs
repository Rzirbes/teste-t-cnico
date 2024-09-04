using System;
using System.Collections.Generic;
using MyCSharpProject.Classes;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1. Resolver Sequências");
            Console.WriteLine("2. Analisar String");
            Console.WriteLine("3. Calcular Soma");
            Console.WriteLine("4. Verificar se um Número Está na Sequência de Fibonacci");
            Console.WriteLine("5. Identificar Interruptor");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            var input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        SolveSequences();
                        break;
                    case 2:
                        AnalyzeString();
                        break;
                    case 3:
                        CalculateSum();
                        break;
                    case 4:
                        CheckFibonacci();
                        break;
                    case 5:
                        IdentifyLightSwitches();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }
        }
    }

    private static void SolveSequences()
{
    var sequences = new Dictionary<string, List<int>>()
    {
        { "A", new List<int> { 1, 3, 5, 7 } },
        { "B", new List<int> { 2, 4, 8, 16, 32, 64 } },
        { "C", new List<int> { 0, 1, 4, 9, 16, 25, 36 } },
        { "D", new List<int> { 4, 16, 36, 64 } },
        { "E", new List<int> { 1, 1, 2, 3, 5, 8 } },
        { "F", new List<int> { 2, 10, 12, 16, 17, 18, 19 } }
    };

    foreach (var seq in sequences)
    {
        int nextValue = seq.Key switch
        {
            "A" => SequenceSolver.SolveSequenceA(seq.Value),
            "B" => SequenceSolver.SolveSequenceB(seq.Value),
            "C" => SequenceSolver.SolveSequenceC(seq.Value),
            "D" => SequenceSolver.SolveSequenceD(seq.Value),
            "E" => SequenceSolver.SolveSequenceE(seq.Value),
            "F" => SequenceSolver.SolveSequenceF(seq.Value),
            _ => throw new NotSupportedException("Sequência desconhecida")
        };

        Console.WriteLine($"Sequência {seq.Key} próxima valor: {nextValue}");
    }

    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}


    private static void AnalyzeString()
    {
        Console.Write("Digite uma string: ");
        var input = Console.ReadLine();

        Console.WriteLine($"Número de ocorrências de 'a' ou 'A': {StringAnalyzer.CountOccurrencesOfA(input)}");
        Console.WriteLine($"A string contém pelo menos um 'a' ou 'A': {StringAnalyzer.ContainsA(input)}");

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    private static void CalculateSum()
    {
        Console.WriteLine($"A soma dos números de 1 até 12 é: {SumCalculator.CalculateSum()}");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    private static void CheckFibonacci()
    {
        Console.Write("Digite um número para verificar se está na sequência de Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            bool isInFibonacci = Fibonacci.IsInFibonacciSequence(number);
            Console.WriteLine($"O número {number} {(isInFibonacci ? "está" : "não está")} na sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    private static void IdentifyLightSwitches()
    {
        LightSwitchSolver.IdentifyLightSwitches();

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}

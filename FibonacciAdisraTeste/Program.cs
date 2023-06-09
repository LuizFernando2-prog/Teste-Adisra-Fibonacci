﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----Sequência de Fibonacci-----");
            Console.WriteLine();
            Console.WriteLine("Informe qual posição da sequência você deseja obter:");
            var itensSequence = int.Parse(Console.ReadLine());


            var sequence = new List<int>() { 0, 1 };

            var newSequence = FibonacciSequence(sequence, itensSequence);

            Console.WriteLine();
            Console.WriteLine("Resultado:");
            Console.WriteLine();

            Console.WriteLine("O número da posição " + itensSequence + " é: " + newSequence[itensSequence]);
        }

        static List<int> FibonacciSequence(List<int> sequence, int itensSequence)
        {
            List<int> newSequence = new List<int>();
            newSequence.AddRange(sequence);

            if (itensSequence == 0)
            {
                return newSequence;
            }

            var lenght = sequence.Count();
            var sum = sequence[lenght - 1] + sequence[lenght - 2];

            newSequence.Add(sum);

            return (FibonacciSequence(newSequence, itensSequence - 1));

        }

    }
}
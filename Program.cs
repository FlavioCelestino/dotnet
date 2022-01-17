using System;

namespace dotnet // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDeVezes=5;
            for (int i=0; i < numeroDeVezes; i++)
            {
                Console.WriteLine($"Bem vindo ao curso de .NET {i}");
            }
        }
    }
}
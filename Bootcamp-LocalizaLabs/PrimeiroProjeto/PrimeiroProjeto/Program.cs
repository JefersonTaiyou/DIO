using System;

namespace PrimeiroProjeto
{
    public class CalculadoraBasica
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            var a = "Hello";
            var b = "World";
            Console.WriteLine($"{a} {b}");
        }
    }
}

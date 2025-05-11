using System;

class FibonacciChecker
{
    static void Main()
    {
        Console.WriteLine("Verificador de Número na Sequência de Fibonacci");
        Console.Write("Informe um número para verificar: ");
        
        if (long.TryParse(Console.ReadLine(), out long numero))
        {
            if (VerificarSePertenceFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} PERTENCE à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO PERTENCE à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }

    static bool VerificarSePertenceFibonacci(long numero)
    {
        if (numero == 0 || numero == 1)
            return true;

        long a = 0;
        long b = 1;
        long c = a + b;

        while (c <= numero)
        {
            if (c == numero)
                return true;
            
            a = b;
            b = c;
            c = a + b;
        }

        return false;
    }
}

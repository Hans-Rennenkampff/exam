using System;

class Program
{
    static void Main(string[] args)
    {
        int m = Prompt("Input M: ");
        int n = Prompt("Input N: ");

        Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
    }

    static int Prompt(string message)
    {
        Console.Write(message);
        int result;
        while (!int.TryParse(Console.ReadLine(), out result) || result < 0)
        {
            Console.WriteLine("Please enter a non-negative integer.");
            Console.Write(message);
        }
        return result;
    }

    static int Akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m > 0 && n == 0) return Akkerman(m - 1, 1);
        else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
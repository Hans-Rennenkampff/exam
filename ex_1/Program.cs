using System;

class Program
{
    static void Main(string[] args)
    {
        int m = Prompt("Input M: ");
        int n = Prompt("Input N: ");
        
        PrintNumbersInRange(m, n);
    }

    static int Prompt(string message)
    {
        Console.Clear();
        Console.Write(message);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
    }

    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            if (m > 0) // Check if m is a natural number
            {
                Console.WriteLine(m);
            }
            PrintNumbersInRange(m + 1, n);
        }
        else
        {
            return; // if m > n stop program
        }
    }
}
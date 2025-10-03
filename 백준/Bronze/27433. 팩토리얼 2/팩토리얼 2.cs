using System;

class Program
{
    static long Factorial(long n)
    {
        if(n == 0) return 1;
        return n * Factorial(n-1);
    }
    
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long k = Factorial(N);
        Console.WriteLine(k);
    }
}
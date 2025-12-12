using System;
class Program
{
    public static int Fibo(int num)
    {
        if(num == 0) return 0;
        if(num == 1) return 1;
        
        return Fibo(num-2) + Fibo(num-1);
        
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int answer =Fibo(n);
        Console.WriteLine(answer);
    }
}
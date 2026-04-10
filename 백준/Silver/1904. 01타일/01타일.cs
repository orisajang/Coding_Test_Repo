using System;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            //1,2,3,5
            //피보나치처럼 되므로 이렇게 해주면 된다.
            int[] fibo = new int[length + 1];

            if (length == 1)
            {
                Console.WriteLine(1);
                return;
            }
            fibo[1] = 1;
            fibo[2] = 2;
            for(int i=3; i<=length; i++)
            {
                fibo[i] = (fibo[i - 2] + fibo[i - 1]) % 15746;
            }
            Console.WriteLine(fibo[length]);
        }
    }
}
using System;
using System.Collections.Generic;

namespace back10872
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long answer = 1;
            for(int i=2; i<= N; i++)
            {
                answer *= i;
            }
            Console.WriteLine(answer);
        }
    }
}
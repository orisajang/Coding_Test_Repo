using System;
using System.Collections.Generic;

namespace back24723
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int answer = 1;
            for(int i=0; i<N; i++)
            {
                answer*= 2;
            }
            Console.WriteLine(answer);
        }
    }
}
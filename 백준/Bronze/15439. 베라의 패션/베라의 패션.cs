using System;
using System.Collections.Generic;

namespace back15439
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int answer = 0;
            for(int i=0; i<N; i++)
            {
                for(int j=0; j<N; j++)
                {
                    if(i != j)
                    {
                        answer++;
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
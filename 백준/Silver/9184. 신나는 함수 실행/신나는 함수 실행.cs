using System;
using System.Collections.Generic;

namespace baek9184
{
    class Program
    {
        static int[,,] memo = new int[21,21,21];
        static bool[,,] visited = new bool[21,21,21];
        private static int w(int a, int b, int c)
        {
            //문제 조건에 맞게 
            if(a<=0 || b<= 0 || c<= 0) { return 1; }
            if(a> 20 || b > 20 || c > 20) { return w(20,20,20); }
            
            //이미 방문했으면 계산한값 그냥 보낸다
            if(visited[a,b,c])
            {
                return memo[a,b,c];
            }
            //방문 안했으면 계산하기
            if(a<b && b<c ) 
            {
                visited[a,b,c] = true;
                memo[a,b,c] = w(a, b, c-1) + w(a, b-1, c-1) - w(a, b-1, c);
            }
            else
            {
                visited[a,b,c] = true;
                memo[a,b,c] = w(a-1, b, c) + w(a-1, b-1, c) + w(a-1, b, c-1) - w(a-1, b-1, c-1);
            }
            return memo[a,b,c];
        }
        
        static void Main(string[] args)
        {
            while(true)
            {
                int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                //3개다 -1이면 종료
                if(inputArray[0] == -1 && inputArray[1] == -1 && inputArray[2] == -1)
                {
                    break;
                }
                
                int result = w(inputArray[0],inputArray[1],inputArray[2]);
                Console.WriteLine($"w({inputArray[0]}, {inputArray[1]}, {inputArray[2]}) = {result}");
            }
        }
    }
}
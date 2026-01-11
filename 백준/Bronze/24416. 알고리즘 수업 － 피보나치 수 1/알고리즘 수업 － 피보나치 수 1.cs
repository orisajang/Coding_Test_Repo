using System;

namespace backjoon24416
{
    class Program
    {
        static int count = 0;
        static int result = 0;
        static void Fibo(int num)
        {
            //DP(다이나믹프로그래밍:문제를쪼갠다)로 피보나치
            int[] fiboArray = new int[num+1];
            //문제 의사코드의 코드를 작성
            fiboArray[1] = 1;
            fiboArray[2] = 1;
            for(int i=3; i<= num; i++)
            {
                fiboArray[i] = fiboArray[i-2] + fiboArray[i-1];
                count++;
            }
            result = fiboArray[num];
        }
        
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //계산값 구하기
            Fibo(num);
            //출력
            Console.WriteLine($"{result} {count}");
        }
    }
}
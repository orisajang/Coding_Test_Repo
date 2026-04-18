using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            int[,] dataArray = new int[n+1, n+1];
            for(int i=1; i<= n; i++)
            {
                int[] numData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 1; j <= n; j++)
                {
                    dataArray[i, j] = numData[j - 1];
                }
            }
            //누적합을 미리 구해놓자
            int[,] sumArray = new int[n + 1, n + 1];
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    sumArray[row, col] =
                        sumArray[row - 1, col] +
                        sumArray[row, col - 1] -
                        sumArray[row - 1, col - 1] +
                        dataArray[row, col];
                }
            }
            //좌표 입력
            StringBuilder sb = new StringBuilder();
            for(int i=0; i< m; i++)
            {
                int[] posData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                //어디부터 어디까지 갈것이다 라는것을 파악해야함
                //만약 2,2~ 3,4 까지 가야한다면?
                int startX = posData[0];
                int startY = posData[1];
                int endX = posData[2];
                int endY = posData[3];

                int result = sumArray[endX, endY] -
                    sumArray[startX - 1, endY] -
                    sumArray[endX, startY - 1] +
                    sumArray[startX - 1, startY - 1];
                sb.AppendLine(result.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
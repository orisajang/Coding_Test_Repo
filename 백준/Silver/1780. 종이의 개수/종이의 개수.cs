using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Test2
{
    class Program
    {
        static int[] result = new int[3];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] data = new int[n, n];
            for(int i=0; i < n; i++)
            {
                int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int j=0; j< inputArray.Length; j++ )
                {
                    data[i, j] = inputArray[j];
                }
            }
            //쿼드트리 탐색
            Func(data, 0, 0, data.GetLength(0));
            for(int i=0; i< result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        
        static void Func(int[,] dataArray, int startX, int startY, int length)
        {
            // 매치 확인
            int num = dataArray[startX, startY];
            bool isMatch = true;
            for (int i = startX; i < startX + length; i++)
            {
                if (!isMatch) break;
                for (int j = startY; j < startY + length; j++)
                {
                    if (dataArray[i, j] != num)
                    {
                        isMatch = false;
                        break;
                    }
                }
            }
            if (isMatch)
            {
                //-1이면 0, 0이면 1, 1이면 2가 되어야함
                result[num + 1]++;
            }
            else
            {
                //9개로 나누자
                int divide = length / 3;
                if(divide == 0)
                {
                    return;
                }
                Func(dataArray, startX, startY, divide);
                Func(dataArray, startX, startY + divide, divide);
                Func(dataArray, startX, startY +  (divide * 2), divide);
                Func(dataArray, startX + divide, startY, divide);
                Func(dataArray, startX + divide, startY + divide, divide);
                Func(dataArray, startX + divide, startY + (divide * 2), divide);
                Func(dataArray, startX + (divide * 2), startY, divide);
                Func(dataArray, startX + (divide * 2), startY + divide, divide);
                Func(dataArray, startX + (divide * 2), startY + (divide * 2), divide);
            }
        }
    }
}
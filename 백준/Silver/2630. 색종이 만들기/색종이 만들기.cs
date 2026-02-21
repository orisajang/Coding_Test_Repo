using System;
using System.Collections.Generic;

namespace baek2630
{
    class Program
    {   
        static int[,] numbers;
        static int[] answer = new int[2];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            numbers = new int[n, n];
            //입력 받기
            for(int i=0; i<n; i++)
            {
                int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < numArray.Length; j++)
                {
                    numbers[i, j] = numArray[j];
                }
            }
            //전체를 확인해서 한색으로 통일되어있는지 확인해야한다
            //만약 1이라면? 1 하고 numbers[0,0] 확인하고 끝
            //만약 2라면? 전체가 똑같은지 확인하고, 아니라면 4개 각각 색상을 확인
            Divide(0, 0, n, n, n);

            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);
        }
        public static void Divide(int startRow,int startCol, int endRow, int endCol,int divideNum)
        {
            int firstColor = numbers[startRow, startCol];
            bool isEnd = true;
            for(int i=startRow; i < endRow; i++)
            {
                for(int j = startCol; j < endCol; j++)
                {
                    if (numbers[i,j] != firstColor)
                    {
                        isEnd = false;
                        break;
                    }
                }
                if (!isEnd) break;
            }
            if(isEnd)
            {
                answer[firstColor]++;
                return;
            }
            //아니라면 4개의 방향으로 나눠줘야 한다.
            int addNumber = divideNum / 2;
        
            //1이라면 그냥 하나 더해주고 끝낸다
            if(addNumber == 0)
            {
                answer[firstColor]++;
                return;
            }
            //4방향으로 나눠주자
            Divide(startRow, startCol, endRow - addNumber, endCol - addNumber, addNumber); //0,0,4,4
            Divide(startRow + addNumber, startCol, endRow, endCol - addNumber, addNumber); //4,0,4,4
            Divide(startRow, startCol + addNumber, endRow - addNumber, endCol, addNumber); //0,0,4,4
            Divide(startRow + addNumber, startCol + addNumber, endRow, endCol, addNumber); //4,4,8,8
        }
    }
}
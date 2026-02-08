using System;
using System.Collections.Generic;
using System.Linq;

namespace back16173
{
    class Program
    {
        static void Main(string[] args)
        {
            //입력처리부터 하자
            int n = int.Parse(Console.ReadLine());
            //n*n의 행렬이 만들어진다.
            List<int[]> positionList = new List<int[]>(); //좌표
            List<bool[]> isVisited = new List<bool[]>(); //방문했는지 여부
            //1. 좌표 생성
            for (int i=0; i< n; i++)
            {
                string[] array = Console.ReadLine().Split(' ').ToArray();
                int[] arrayNum = new int[array.Length];
                for(int j=0; j<array.Length; j++)
                {
                    arrayNum[j] = int.Parse(array[j]);
                }
                positionList.Add(arrayNum);
                isVisited.Add(new bool[n]); //방문했는지 좌표
            }
            
            //2. 오른쪽과 아래로만 이동할 수 있다. (현재칸에 쓰여있는 횟수만큼 이동)
            // 즉, 오른쪽과 아래를 추가한다. (BFS같음) -> Queue로 추가
            //처음시작은 무조건 0,0
            Queue<(int, int)> positionQue = new Queue<(int, int)>();
            positionQue.Enqueue((0, 0));
            isVisited[0][0] = true;
            //3. 만약에 쭉 이동하다가 -1이 적혀있는 칸을 만나면 HaruHaru 출력, 안된다면 Hing출력
            //visited[]에 다시 방문하거나, 칸을 넘어가는 경우면 안함. Queue의 Count가 0이면 안되는거
            while(positionQue.Count > 0)
            {
                (int, int) tuple = positionQue.Dequeue();
                //현재 칸에 쓰여있는 이동 횟수는?
                int move = positionList[tuple.Item1][tuple.Item2];
                
                if(move == -1)
                {
                    //종료. 끝내야함
                    Console.WriteLine("HaruHaru");
                    return;
                }
                //이동값만큼 오른쪽과 아래로 이동할 수 있는지 체크한다. (좌표가 n보다 크거나 같으면 추가안함, 이미 방문했으면 추가안함)
                int posX = tuple.Item2 + move;
                int posY = tuple.Item1 + move;
                //1. 오른쪽 추가
                if(posX < n && !isVisited[tuple.Item1][posX])
                {
                    positionQue.Enqueue((tuple.Item1, posX));
                    isVisited[tuple.Item1][posX] = true;
                }
                //2. 아래 추가
                if(posY < n && !isVisited[posY][tuple.Item2])
                {
                    positionQue.Enqueue((posY, tuple.Item2));
                    isVisited[posY][tuple.Item2] = true;
                }
            }
            //만약 못찾았으면
            Console.WriteLine("Hing");
        }
    }
}
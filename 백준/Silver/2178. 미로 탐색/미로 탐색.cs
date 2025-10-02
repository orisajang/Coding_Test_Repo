using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int N = int.Parse(nm[0]);
        int M = int.Parse(nm[1]);

        int[,] map = new int[N, M];
        bool[,] visited = new bool[N, M];

        for (int i = 0; i < N; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < M; j++)
            {
                map[i, j] = line[j] - '0'; // 문자 '1','0' → 숫자 1,0
            }
        }
        //map을 얻었음
        //지도, 거리, 방문했는지확인, 상하좌우 확인
        int[] nx = new int[]{-1,1,0,0};
        int[] ny = new int[]{0,0,-1,1};
        Queue<(int,int)> q = new Queue<(int,int)>();
        q.Enqueue((0,0));
        int xLength = map.GetLength(0);
        int yLength = map.GetLength(1);
        int[,] distance = new int[xLength,yLength];
        distance[0,0] = 1;
        visited[0,0] = true;
        
        while(q.Count !=0)
        {
            var (x,y) = q.Dequeue();
            for(int i=0; i<4; i++)
            {
                int dx = nx[i] + x;
                int dy = ny[i] + y;
                
                if(dx >= 0 && dy >= 0 && dx < xLength && dy < yLength)
                {
                    if(dx ==N-1 && dy == M-1)
                    {
                        int k = distance[x,y] + 1;
                        Console.Write(k);
                        return;
                    }
                    if(!visited[dx,dy] && map[dx,dy] ==1)
                    {
                        visited[dx,dy] = true;
                        distance[dx,dy] = distance[x,y] +1;
                        q.Enqueue((dx,dy));
                    }
                }
                
            }
        }
        Console.Write("-1"); 
        return;
        
    }
}
using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        int answer = 0;
        //BFS에서 필요한것
        //거리, 맵, queue<(int,int)>, isVisit, 이동방향(상하좌우),
        int xLength = maps.GetLength(0);
        int yLength = maps.GetLength(1);
        
        int[] nx = new int[] {-1,1,0,0};
        int[] ny = new int[] {0,0,-1,1};
        Queue<(int,int)> q = new Queue<(int,int)>();
        q.Enqueue((0,0));
        bool[,] isVisit  = new bool[xLength,yLength];
        int[,] distance = new int[xLength,yLength];
        isVisit[0,0] = true;
        distance[0,0] = 1;
        
        while(q.Count != 0)
        {
            var (x,y) = q.Dequeue();
            
            for(int i=0; i<4; i++)
            {
                int dx = nx[i] + x;
                int dy = ny[i] + y;
                if(dx >=0 && dy >=0 && dx < xLength&& dy < yLength)
                {
                    if(!isVisit[dx,dy] && maps[dx,dy] == 1)
                    {
                        isVisit[dx,dy] = true;
                        distance[dx,dy] = distance[x,y] + 1;
                        q.Enqueue((dx,dy));
                    }
                }
            }
        }
        
        return distance[xLength-1, yLength-1] == 0 ? -1 : distance[xLength-1, yLength-1];
        
        //return answer;
    }
}
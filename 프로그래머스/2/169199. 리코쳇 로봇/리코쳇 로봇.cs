using System;
using System.Collections.Generic;

public class Solution {
    private enum eDir { left, right, down,up };
    
    Queue<(int,int)> que = new Queue<(int,int)>();
    int[] dx = new int[4]{-1,1,0,0};
    int[] dy = new int[4]{0,0,-1,1};
    public int solution(string[] board) {
        int answer = 0;
        //특정 지점에 처음 도달한 횟수를 저장해볼까? 그럴려면? BFS? Queue
        //bool로 좌표를 생성시켜보자(가장 최단거리로, 최초로 목표에 도달한 위치)
        int[,] posArray = new int[board.Length, board[0].Length];
        //board에서 시작 좌표를 찾아야함(R)
        int startX = 0;
        int startY = 0;
        bool isFindPos = false;
        for(int row=0; row < board.Length; row++)
        {
            if(isFindPos) break;
            for(int col=0; col < board[0].Length; col++)
            {
                if(board[row][col] == 'R')
                {
                    startX = row;
                    startY = col;
                    isFindPos = true;
                    break;
                }
            }
        }
        //시작위치에서 BFS로 Queue에 추가하면서 쭉쭉 이동해보자
        posArray[startX,startY] = 1;
        que.Enqueue((startX,startY));
        
        while(que.Count > 0)
        {
            var (posX,posY) = que.Dequeue();
            int currentValue = posArray[posX,posY];
            //상하좌우 모두 가능한지 체크하고, 이동시켜볼거임    
            for(int i=0; i< dx.Length; i++)
            {
                var (item1,item2) = GetPos(board,posX,posY, (eDir)i);
                //골에 도달했는지 체크
                if(board[item1][item2] == 'G')
                {
                    //처음에 +1로 시작했으므로 그냥 안더하고 return
                    return currentValue;
                }
                //아니라면 계속 탐색
                if(posArray[item1,item2] == 0 || posArray[item1,item2] > currentValue+1 )
                {
                    //한번 실행
                    que.Enqueue((item1,item2));
                    posArray[item1,item2] = currentValue+1;
                }
            }
        }
        return -1;
    }
    private (int, int) GetPos(string[] board, int posX, int posY, eDir dir)
    {
        int curX = posX;
        int curY = posY;
        int num = (int)dir;

        while(true)
        {   
            int nextX = curX + dx[num];
            int nextY = curY + dy[num];
            
            if(nextX < 0 || nextX >= board.Length || nextY < 0 || nextY >= board[0].Length)
            {
                return (curX, curY);
            }
            if(board[nextX][nextY] == 'D')
            {
                return (curX, curY);
            }
            curX = nextX;
            curY = nextY;
        }
    }
    
}
using System;
using System.Collections.Generic;

public class Solution {
    int[] posX = new int[]{0,0,-1,1};
    int[] posY = new int[]{-1,1,0,0};
    int[,] visitedLever;
    int[,] visitedExit;
    Queue<(int x,int y)> que = new Queue<(int,int)>();
    public int solution(string[] maps) {
        int answer = -1;
        //visited를 2개 해야함. 레버 1차로 찾고, 그다음에 통로를 찾아야함. BFS?
        //상하좌우 십자형태로 추가해야함. 좌표를 튜플? 혹은 암튼 좌표 저장하기
        //1차로 레버를 찾고난뒤에 그 위치에서 탈출구를 찾아야함. 벽은 X
        int lengthX = maps.Length;
        int lengthY = maps[0].Length;
        visitedLever = new int[lengthX,lengthY];
        visitedExit = new int[lengthX,lengthY];
        
        //처음은 출발지를 찾아야함
        int currentX = 0;
        int currentY = 0;
        bool isFind = false;
        for(int row = 0; row < lengthX; row++)
        {
            if(isFind) break;
            for(int col = 0; col < lengthY; col++)
            {
                if(maps[row][col] == 'S')
                {
                    currentX = row;
                    currentY = col;
                    break;
                }
            }
        }
        //시작지점에서 BFS방식으로 레버를 찾자
        //좌표가 유효한지 체크해야함
        que.Enqueue((currentX,currentY));
        visitedLever[currentX,currentY] = 1;
        bool isFindLever = false;
        while(que.Count > 0 && !isFindLever)
        {
            var (curX, curY) = que.Dequeue();
            
            for(int i=0; i< posX.Length; i++)
            {
                int row = curX + posX[i];
                int col = curY + posY[i];
                if(!IsExistPos(row,col,lengthX,lengthY)) continue;
                if(visitedLever[row,col] > 0) continue;
                if(maps[row][col] == 'X') continue;
                //해당 포지션으로 이동
                visitedLever[row,col] = visitedLever[curX,curY] + 1;
                if(maps[row][col] == 'L')
                {
                    isFindLever = true;
                    currentX = row;
                    currentY = col;
                    break;
                }
                else
                {
                    que.Enqueue((row,col));
                }
            }
        }
        Console.WriteLine($"{currentX},{currentY}, {visitedLever[currentX,currentY]}");
        //만약에 찾았으면? 이제 출구를 찾자
        bool isFindExit = false;
        que.Clear();
        visitedExit[currentX, currentY] = visitedLever[currentX,currentY];
        que.Enqueue((currentX,currentY));
        while(que.Count > 0 && !isFindExit && isFindLever)
        {
             var (curX, curY) = que.Dequeue();
            for(int i=0; i< posX.Length; i++)
            {
                int row = curX + posX[i];
                int col = curY + posY[i];
                if(!IsExistPos(row,col,lengthX,lengthY)) continue;
                if(visitedExit[row,col] > 0) continue;
                if(maps[row][col] == 'X') continue;
                //해당 포지션으로 이동
                visitedExit[row,col] =  visitedExit[curX,curY] + 1;
                if(maps[row][col] == 'E')
                {
                    isFindExit = true;
                    answer = visitedExit[row,col] -1;
                    break;
                }
                else
                {
                    que.Enqueue((row,col));
                }
            }
        }
        
        return answer;
    }
    
    
    private bool IsExistPos(int posX, int posY, int maxX, int maxY)
    {
        if(posX < 0 || posY < 0 || posX >= maxX || posY >= maxY) return false;
        return true;
    }
    
    
}
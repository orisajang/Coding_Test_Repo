using System;
using System.Collections.Generic;

public class Solution {
    int[] posX = new int[]{0,0,-1,1};
    int[] posY = new int[]{-1,1,0,0};
    int[,] visitedLever;
    int[,] visitedExit;
    Queue<(int x,int y)> que = new Queue<(int,int)>();
    int currentX = 0;
    int currentY = 0;
    public int solution(string[] maps) {
        int answer = -1;
        //visited를 2개 해야함. 레버 1차로 찾고, 그다음에 통로를 찾아야함. BFS?
        //상하좌우 십자형태로 추가해야함. 좌표를 튜플? 혹은 암튼 좌표 저장하기
        int lengthX = maps.Length;
        int lengthY = maps[0].Length;
        visitedLever = new int[lengthX,lengthY];
        visitedExit = new int[lengthX,lengthY];
        
        //처음은 출발지를 찾아야함
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
        que.Enqueue((currentX,currentY));
        visitedLever[currentX,currentY] = 1;
        
        if(BFS(maps,visitedLever,'L'))
        {
            que.Clear();
            visitedExit[currentX, currentY] = visitedLever[currentX,currentY];
            que.Enqueue((currentX,currentY));
            if(BFS(maps,visitedExit,'E'))
            {
                answer = visitedExit[currentX,currentY] -1;
            }
        }
        return answer;
    }
    
    
    private bool IsExistPos(int posX, int posY, int maxX, int maxY)
    {
        if(posX < 0 || posY < 0 || posX >= maxX || posY >= maxY) return false;
        return true;
    }
    
    private bool BFS(string[] maps, int[,] visited, char findLetter)
    {        
        int lengthX = maps.Length;
        int lengthY = maps[0].Length;
        while(que.Count > 0)
        {
            var (curX, curY) = que.Dequeue();
            
            for(int i=0; i< posX.Length; i++)
            {
                int row = curX + posX[i];
                int col = curY + posY[i];
                if(!IsExistPos(row,col,lengthX,lengthY)) continue;
                if(visited[row,col] > 0) continue;
                if(maps[row][col] == 'X') continue;
                //해당 포지션으로 이동
                visited[row,col] = visited[curX,curY] + 1;
                if(maps[row][col] == findLetter)
                {
                    currentX = row;
                    currentY = col;
                    return true;
                }
                else
                {
                    que.Enqueue((row,col));
                }
            }
        }
        return false;
    }
}
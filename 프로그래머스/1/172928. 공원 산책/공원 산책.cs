using System;

public class Solution {
    public int[] SetDirection(char c,int moveNum)
    {
        int[] array = new int[2];
        int moveX = 0;
        int moveY = 0;
        if(c == 'E') moveY = moveNum;
        else if(c == 'W') moveY = -moveNum;
        else if(c == 'S') moveX = moveNum;
        else if(c == 'N') moveX = -moveNum;
        
        array[0] = moveX;
        array[1] = moveY;
        return array;
    }
    
    
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[2];
        int xLength = park.Length;
        int yLength = park[0].Length;
        //초기 위치는 0,0이 아니다. 찾아야함
        int[] startPos = new int[2];
        for(int i=0; i< xLength; i++)
        {
            for(int j=0; j< yLength; j++)
            {
                if(park[i][j] == 'S')
                {
                    startPos[0] = i;
                    startPos[1] = j;
                }
            }
        }
        //이동해야할 루트에 따라 이동한다
        for(int i=0; i< routes.Length; i++)
        {
            //방향 과 얼마만큼 이동해야하는지 정보 얻어옴
            int[] dir = new int[2];
            int moveNum = routes[i][2] - '0';
            dir = SetDirection(routes[i][0], moveNum);
            //이동 (park의 X는 가지못하고, 배열바깥에도 가면안됨)
            //E 2 라면? dir에는 0, 2 존재
            //플레이어 위치는 startPos에 있음 0,0
            
            //조건1. 먼저 배열 바깥 넘어가는지 확인하자
            int[] addDir = new int[2];
            addDir[0] = startPos[0] + dir[0];
            addDir[1] = startPos[1] + dir[1];
            if(addDir[0] >= 0 && addDir[0] < xLength &&
              addDir[1] >= 0 && addDir[1] < yLength)
            {
                //조건2.거리 이동시 중간에 벽이 있으면 움직이지 못함
                bool isMoveSuccess = true;
                int posX = startPos[0];
                int posY = startPos[1];
                for(int k=0; k< moveNum; k++)
                {
                    if(dir[0] > 0) posX++;
                    else if(dir[0] < 0) posX--;
                    else if(dir[1] > 0) posY++;
                    else if(dir[1] < 0) posY--;
                    
                    if(park[posX][posY] == 'X') 
                    {
                        isMoveSuccess = false;
                        break;
                    }
                }
                if(isMoveSuccess)
                {
                    startPos[0] = addDir[0];
                    startPos[1] = addDir[1];
                }
            }
        }
        
        answer[0] = startPos[0];
        answer[1] = startPos[1];
        
        return answer;
    }
}
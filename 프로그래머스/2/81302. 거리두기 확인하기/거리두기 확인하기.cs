using System;
using System.Collections.Generic;

public class Solution {
    int[] dx = {-1,1,0,0};
    int[] dy = {0,0,-1,1};
    int limitDistnace = 2;
    
    public int[] solution(string[,] places) {
        //맨해튼 거리가 2 이하인지 체크해야함. 일단 대기실 1개로 체크해보자 (BFS? 상하좌우?)
        //대기실 하나부터 만들어보자
        int[] answer = new int[places.GetLength(0)];
        for(int i=0; i< answer.Length; i++)
        {
            answer[i] = 1;
        }
        for(int robby=0; robby< places.GetLength(0); robby++)
        {
            string[] str = new string[5];
            for(int j= 0; j< places.GetLength(1); j++)
            {
                str[j] = places[robby,j];
            }
            //일단 P를 찾아본다.
            bool isFind = false;
            for(int row=0; row< str.Length; row++)
            {
                if(isFind) break;
                for(int col=0; col< str[0].Length; col++)
                {
                    //P위치를 찾자
                    if(str[row][col] == 'P')
                    {
                        //현재 위치와 데이터를 보내자
                        if(Func(str,row,col))
                        {
                            isFind = true;
                            answer[robby] = 0;
                            break;
                        }
                    }
                }
            }
        }
        return answer;
    }
    private bool Func(string[] str, int startX,int startY)
    {
        //Queue로 시작해보자
        Queue<(int,int,int)> que = new Queue<(int,int,int)>();
        que.Enqueue((startX,startY,0));
        bool[,] isVisited = new bool[str.Length, str[0].Length];
        isVisited[startX,startY] = true;
        while(que.Count > 0)
        {
            var (curX,curY,count) = que.Dequeue();
            if(count >= limitDistnace) continue;
            //현재 좌표에서 상하좌우를 체크하자.
            for(int i=0; i< dx.Length; i++)
            {
                int posX = curX + dx[i];
                int posY = curY + dy[i];
                //벽을넘어가지 않았는지 체크해야한다
                if(posX < 0 || posY < 0 || 
                   posX >=str.Length || posY >= str[0].Length) continue;
                //또한 이전에 방문한 장소가 아니어야 하는데?
                if(isVisited[posX,posY]) continue;
                isVisited[posX,posY] = true;
                if(str[posX][posY] == 'P')
                {
                    return true;
                }
                else if(str[posX][posY] == 'O')
                {
                    //한번더 올려버리자
                    if(count +1 >= limitDistnace) continue;
                    que.Enqueue((posX,posY,count+1));
                }
            }
        }
        return false;
    }
}
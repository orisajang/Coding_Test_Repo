using System;
using System.Collections.Generic;

public class Solution {
    int[] dx = new int[4]{-1,1,0,0};
    int[] dy = new int[4]{0,0,-1,1};
    public int solution(string[] storage, string[] requests) {
        int answer = 0;
        //다른방법. 외부 공기를 BFS로 만든다 (전체크기에서 외각을 감싸는 배열을 하나 만들자)
        char[,] airArray = new char[storage.Length+2, storage[0].Length+2];
        for(int i=0; i< airArray.GetLength(0); i++)
        {
            for(int j=0; j< airArray.GetLength(1); j++)
            {
                //외각은 전부 true, 나머지는 false로 만들어주자
                if(i == 0 || j == 0 || 
                   i == airArray.GetLength(0) - 1 || j == airArray.GetLength(1) - 1)
                {
                    airArray[i,j] = '.';
                }
                else
                {
                    airArray[i,j] = storage[i-1][j-1];
                }
            }
        }
        //답을 구해보자
        for(int i=0; i< requests.Length; i++)
        {
            if(requests[i].Length == 1)
            {
                //외각과 뚫려있으면 풀수있음. 단 이전에 빠진것들이 결과에 반영되면 안됨
                //하기전에 공기 배열을 미리 만들어두자
                Queue<(int,int)> que = new Queue<(int,int)>();
                bool[,] isVisited = new bool[airArray.GetLength(0), airArray.GetLength(1)];
                bool[,] outsideArray =new bool[airArray.GetLength(0), airArray.GetLength(1)];
                que.Enqueue((0,0));
                isVisited[0,0] = true;
                while(que.Count > 0)
                {
                    var (posX,posY) =  que.Dequeue();
                    if(airArray[posX,posY] == '.')
                    {
                        outsideArray[posX,posY] = true;
                        for(int idx=0; idx< dx.Length; idx++)
                        {
                            int curX = posX + dx[idx];
                            int curY = posY + dy[idx];
                            if(curX < 0 || curY < 0 || 
                               curX >= airArray.GetLength(0) || curY >= airArray.GetLength(1))
                            {
                                continue;
                            }
                            if(isVisited[curX,curY]) continue;
                            isVisited[curX,curY] = true;
                            que.Enqueue((curX,curY));
                        }
                    }
                }
                //공기 배열을 얻었음. 이제 상하좌우로 공기 배열이 있는지 체크하면된다.
                for(int row = 1; row < airArray.GetLength(0)-1; row++)
                {
                    for(int col = 1; col < airArray.GetLength(1)-1; col++)
                    {
                        if(airArray[row,col] == requests[i][0])
                        {
                            //상하좌우에 공기가 있는지 체크
                            for(int idx = 0; idx < dx.Length; idx++)
                            {
                                int curX = row + dx[idx];
                                int curY = col + dy[idx];
                                //무조건 1이랑 최대크기 -1범위니까 0체크 필요없다
                                if(outsideArray[curX,curY])
                                {
                                    airArray[row,col] = '.';
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                //그냥 다 뽑으면 됨
                for(int row = 1; row < airArray.GetLength(0)-1; row++)
                {
                    for(int col = 1; col < airArray.GetLength(1)-1; col++)
                    {
                        if(airArray[row,col] == requests[i][0])
                        {
                            airArray[row,col] = '.';
                        }
                    }
                }
            }
        }
        //answer를 늘리자
        for(int i=0; i< airArray.GetLength(0); i++)
        {
            for(int j= 0; j< airArray.GetLength(1); j++)
            {
                if(airArray[i,j] != '.')
                {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}
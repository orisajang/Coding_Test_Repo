using System;
using System.Collections.Generic;

public class Solution {
    int[] dx = new int[4] {-1,1,0,0};
    int[] dy = new int[4] {0,0,-1,1};
    public int solution(string[] storage, string[] requests) {
        int answer = 0;
        //requests를 체크하면서 1개가 나오면 지게차로, 2개면 그냥 해당되는거 전부 다 빼기
        for(int i=0; i< requests.Length; i++)
        {
            string str = requests[i];
            if(str.Length == 1)
            {
                bool[,] isVisited = new bool[storage.Length,storage[0].Length];
                for(int row=0; row< storage.Length; row++)
                {
                    char[] ch = storage[row].ToCharArray();
                    for(int col = 0; col < storage[row].Length; col++)
                    {
                        
                        if(storage[row][col] != str[0]) continue;
                        //현재위치에서 상하좌우 4방향에 대해 비어있는지, 및 방문 체크
                        Queue<(int,int)> que = new Queue<(int,int)>();
                        que.Enqueue((row,col));
                        bool isPossible = false;
                        bool[,] visited = new bool[storage.Length,storage[0].Length];
                        while(que.Count > 0)
                        {
                            var (posX,posY) = que.Dequeue();
                            for(int idx = 0; idx < dx.Length; idx++)
                            {
                                int curX = posX + dx[idx];
                                int curY = posY + dy[idx];
                                if(curX < 0 || curY < 0 || 
                               curX >= storage.Length || curY >= storage[row].Length)
                                {
                                    //가능하다는거임
                                    isPossible = true;
                                    break;
                                }
                                //아니라면? BFS 추가 가능한지 체크를 해야함
                                if(visited[curX,curY] || isVisited[curX,curY] || 
                                  storage[curX][curY] != '0') continue;
                                visited[curX,curY] = true;
                                que.Enqueue((curX,curY));
                            }
                        }
                        if(isPossible) 
                        {
                            ch[col] = '0';
                            isVisited[row,col] = true;
                        }
                    }
                    storage[row] = new string(ch);
                }
            }
            else
            {
                //크레인으로 전부 다 뽑아버리자
                for(int row=0; row< storage.Length; row++)
                {
                    char[] ch = storage[row].ToCharArray();
                    for(int col = 0; col < storage[0].Length; col++)
                    {
                        if(storage[row][col] == str[0])
                        {
                            ch[col] = '0';
                        }
                    }
                    storage[row] = new string(ch);
                }
            }
        }
        //숫자를 세보자
        for(int row = 0; row < storage.Length; row++)
        {
            for(int col =0; col < storage[0].Length; col++)
            {
                if(storage[row][col] != '0') { answer++; }
            }
        }
        return answer;
    }
}
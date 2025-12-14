using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int x, int y, int n) {
        int answer = 0;
        //사용할 수 있는 연산이 있다, 어떤게 최단거리인지는 모른다
        //BFS는 최단거리다. Queue로 구현한다, DFS는 모든 경우의 수
        //사용할수 있는 연산값을 현재 x에 더해서 계속 가져간다면 된다
        //몇번안에 성공했는지와, 현재값을 가져가야하므로 튜플을 써보자
        Queue<(int,int)> que = new Queue<(int,int)>();
        bool[] visited = new bool[y+1];
        
        //초기값 넣기 (시작 x, 횟수 0부터 시작)
        que.Enqueue((x,0));
        visited[x] = true;
        
        while(que.Count > 0)
        {
            //하나 빼준다
            (int current,int count) = que.Dequeue();
            //뺀값이 y랑 똑같다면?
            if(current == y) return count;
            //아니라면? 연산3개를 전부 que에 넣어줌
            int[] addValue = new int[]
            {
                current+n,
                current*2,
                current*3
            };
            //foreach돌려서 넣어준다
            foreach(var item in addValue)
            {
                //한번도 방문한적없고, 숫자가 y보다 작으면
                
                if(item <= y && !visited[item])
                {
                    visited[item] = true;
                    que.Enqueue((item,count+1));
                }
                
            }
            
        }
        
        //다 했는데 못찾았으면
        return -1;
    }
}
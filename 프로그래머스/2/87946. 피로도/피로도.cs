using System;

public class Solution {
    bool[] isVisited;
    int answer = -1;
    public int solution(int k, int[,] dungeons) {
        
        //현재 피로도로 탐색할수있는 던전을 확인하자
        //던전갯수와 실행횟수가 같다면 바로 종료 
        //123, 132, 213, 231, ... 6개
        //이거 isvisited로 처리해야할듯? DFS 처럼?
        int currentRes = 0;
        isVisited = new bool[dungeons.GetLength(0)];
        Func(k,dungeons,0);
        
        return answer;
    }
    private void Func(int k, int[,] dungeons, int count)
    {
        int min= 0;
        int somo = 0;
        for(int i=0; i< dungeons.GetLength(0); i++)
        {
            if(isVisited[i]) { continue; }
            
            
            min = dungeons[i,0];
            somo = dungeons[i,1];
            
            //만약 조건에 걸렸다면?
            if(k >= min)
            {
               //계속 갑시다
                if(dungeons.GetLength(0) == count+1)
                {
                   //끝냅시다.
                   answer = count+1;
                   return;
               }
                isVisited[i] = true;
                Func(k-somo,dungeons,count+1);
                isVisited[i] = false;
            }
            else
            {
                //끝
                if(count > answer) { answer = count; }
                continue;
            }
        }
        
        return;
    }
}
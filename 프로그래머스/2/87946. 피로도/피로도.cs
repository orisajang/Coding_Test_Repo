using System;

public class Solution {
    bool[] isVisited;
    int answer = -1;
    public int solution(int k, int[,] dungeons) {
        
        //DFS는? isVisited체크하면서 쭉쭉 내려가보자
        isVisited = new bool[dungeons.GetLength(0)];
        DFS(k,dungeons,0);
        
        return answer;
    }
    private void DFS(int k, int[,] dungeons, int count)
    {
        //하나씩 체크하면서 들어가야함 for문
        for(int i=0; i< dungeons.GetLength(0); i++)
        {
            if(isVisited[i]) continue;
            if(answer == dungeons.GetLength(0)) return;
            
            int min = dungeons[i,0];
            int somo = dungeons[i,1];
            
            if(k >= min)
            {
                //입장 가능 DFS가자
                //만약 최대 result와 동일하다면 바로 끝내면됨
                if(dungeons.GetLength(0) == count+1)
                {
                    answer = count+1;
                    return;
                }
                isVisited[i] = true;
                DFS(k-somo, dungeons, count+1);
                isVisited[i] = false;
            }
            else
            {
                //더이상 갈수없음. 
                if(count > answer) { answer = count; }
                continue;
            }
            
        }
    }
}
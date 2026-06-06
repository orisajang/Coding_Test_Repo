using System;
using System.Collections.Generic;

public class Solution {
    int sum = 0;
    int[] dx = new int[]{0,0,-1,1};
    int[] dy = new int[]{-1,1,0,0};
    int lengthX;
    int lengthY;
    public int[] solution(string[] maps) {
        int[] answer = new int[] {};
        //isVisited로 방문 체크, 전부 종료되면 sum 초기화.
        //상하좌우를 체크하자
        
        //방문 체크는?
        lengthX = maps.Length;
        lengthY = maps[0].Length;
        bool[,] isVisited = new bool[lengthX,lengthY];
        
        List<int> resultList = new List<int>();
        
        //이제 for문 돌아가면서 하나씩 들어가자
        for(int row = 0; row < lengthX; row++)
        {
            for(int col = 0; col < lengthY; col++ )
            {
                if(isVisited[row,col]) continue;
                //여기서부터 DFS방식으로 쭉쭊 타고 들어가자
                DFS(maps,isVisited,row,col);
                //전부 끝났다면?
                if(sum != 0)
                {
                    resultList.Add(sum);
                }
                sum = 0;
            }
        }
        resultList.Sort();
        
        if(resultList.Count > 0)
        {
            answer = resultList.ToArray();
        }
        else
        {
            answer = new int[1];
            answer[0] = -1;
        }
        return answer;
    }
    public void DFS(string[] maps, bool[,] visited, int row, int col)
    {
        //뭐가 필요하니?  방문 기록, 합산 데이터, 현재 데이터가 X가 아닌지, 
        //while문으로 반복해서 계속 로직을 실행해야함.
        if(visited[row,col]) return;
        visited[row,col] = true;
        
        //char이기때문에 숫자 변화를 시켜야함.
        if(int.TryParse(maps[row][col].ToString(), out int numBuf))
        {
            sum+= numBuf;
        }
        else
        {
            return;
        }
        //숫자일떄만 가자
        for(int i=0; i< dx.Length; i++)
        {
            int currentX = row + dx[i];
            int currentY = col + dy[i];
            
            if(IsVailed(currentX,currentY) && !visited[currentX,currentY])
            {
                DFS(maps,visited,row+dx[i], col + dy[i]);
            }
        }
    }
    
    private bool IsVailed(int x, int y)
    {
        if(x < 0 || x >= lengthX || y < 0 || y >= lengthY)
        {
            return false;
        }
        return true;
    }
    
    
}
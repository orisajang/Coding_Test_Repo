using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        int[] dx = new int[]{-1,-1,-1,0,0,0,1,1,1};
        int[] dy = new int[]{-1,0,1,-1,0,1,-1,0,1};
        
        int length = board.GetLength(0);
        
        for(int x=0; x<length; x++)
        {
            for(int y=0; y< length; y++)
            {
                if(board[x,y] == 1) continue;
                bool isSafe = true;
                for(int k=0; k < dx.Length; k++)
                {
                    int nx = dx[k] + x;
                    int ny = dy[k] + y;
                    
                    if(nx >= 0 && nx < length && ny >= 0 && ny < length)
                    {
                        if(board[nx,ny] == 1)
                        {
                            isSafe = false;
                            break;
                        }
                    }
                }
                if(isSafe)
                {
                    answer++;    
                }
            }
        }
        
        
        return answer;
    }
}
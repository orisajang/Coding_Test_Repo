using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        
        int rowLength = board.GetLength(0);
        int colLength = board.GetLength(1);
        for(int row = 0; row < rowLength; row++ )
        {
            for(int col = 0; col < colLength; col++)
            {
                if(board[row,col] == 1) continue;
                //0이라면 주변을 체크하자
                if(row != 0)
                {
                    if(board[row-1,col] == 1) continue; 
                }
                if(col != 0)
                {
                    if(board[row,col-1] == 1) continue;
                }
                if(row != 0 && col != 0)
                {
                    if(board[row-1,col-1] ==1) continue;
                }
                if(row != rowLength-1)
                {
                    if(board[row+1,col] == 1) continue;
                }
                if(col != colLength-1)
                {
                    if(board[row,col+1] == 1) continue;
                }
                if(row != rowLength-1 && col != 0)
                {
                    if(board[row+1,col-1] == 1) continue;
                }
                if(row != 0 && col != colLength-1)
                {
                    if(board[row-1,col+1] == 1) continue;
                }
                if(row != rowLength-1 && col != colLength-1)
                {
                    if(board[row+1,col+1] == 1) continue;
                }
                answer++;
            }
        }
        
        
        return answer;
    }
}
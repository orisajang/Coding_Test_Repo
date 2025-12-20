using System;

public class Solution {
    public int solution(int[,] board, int k) {
        int answer = 0;
        //그냥 이차원 배열 돌아가면서 k보다 작거나 같은수 더하면됨
        int x = board.GetLength(0); // 4
        int y = board.GetLength(1); // 3
        for(int i=0; i<x; i++)
        {
            for(int j=0; j<y; j++)
            {
                int sum = i+j;
                if(sum <= k)
                {
                    answer += board[i,j];
                }
            }
        }
        return answer;
    }
}
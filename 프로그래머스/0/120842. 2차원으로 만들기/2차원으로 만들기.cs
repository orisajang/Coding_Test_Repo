using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int row = num_list.Length / n;
        int[,] answer = new int[row,n];
        
        for(int x = 0; x< row; x++)
        {
            for(int y=0; y < n; y++)
            {
                int current = (x *n) + y;
                answer[x,y] = num_list[current];
            }
        }
        
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        //노란색은 x축 -2 y축 -2를 한 갯수다.
        //3*3 = 9, 1*1 = 1
        //4*3 = 12, 1*2 = 2;
        
        int total = brown + yellow;
        for(int row = 3; row <= total; row++)
        {
            for(int col = 3; col <= row; col++ )
            {   
                if(row * col != total) continue;
                if(((row-2) * (col-2)) != yellow) continue;
                answer[0] = row;
                answer[1] = col;
                return answer;
            }
        }
        
        
        return answer;
    }
}
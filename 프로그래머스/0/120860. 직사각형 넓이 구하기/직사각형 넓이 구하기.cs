using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int lengthX = dots.GetLength(0);
        int lengthY = dots.GetLength(1);
        
        int minX = dots[0,0];
        int maxX = dots[0,0];
        int minY = dots[0,1];
        int maxY = dots[0,1];
        for(int i=0; i< lengthX; i++)
        {
            if(minX > dots[i,0])
            {
                minX = dots[i,0];
            }
            if(maxX < dots[i,0])
            {
                maxX = dots[i,0];
            }
            if(minY > dots[i,1])
            {
                minY = dots[i,1];
            }
            if(maxY < dots[i,1])
            {
                maxY = dots[i,1];
            }
        }
        int resultX = maxX - minX;
        int resultY = maxY - minY;
        answer = resultX * resultY;
        
        
        
        
        return answer;
    }
}
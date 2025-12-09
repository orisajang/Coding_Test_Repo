using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[2];
        
        //현재 x와 y좌표
        int x = 0;
        int y = 0;
        int xMin = -board[0] / 2;
        int xMax = board[0] / 2;
        int yMin = -board[1] / 2;
        int yMax = board[1] / 2;
        
        for(int i=0; i<keyinput.Length; i++)
        {
            if(keyinput[i] == "left") if(x > xMin) x-=1;
            if(keyinput[i] == "right") if(x < xMax) x+=1;
            if(keyinput[i] == "down") if(y > yMin) y-=1;
            if(keyinput[i] == "up") if(y < yMax) y+=1;
            
            Console.WriteLine($"{x},{y}");
        }
        answer[0] = x;
        answer[1] = y;
        return answer;
    }
}
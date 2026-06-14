using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string dirs) {
        int answer = 0;
        //HashSet도 가능하고, int[,,,] 이거도 가능함
        //HashSet<string> hash = new HashSet<string>();
        int[,,,] recordPos = new int[11,11,11,11];
        int posX = 5;
        int posY = 5;
        
        //좌표는 -5 ~ 5 이상으로 넘어갈수 없음.
        for(int i=0; i< dirs.Length; i++)
        {
            int beforeX = posX;
            int beforeY = posY;
            if(dirs[i] == 'U')
            {
                //위쪽으로 이동;
                if(posY +1 > 10) continue;
                posY += 1;
            }
            else if(dirs[i] == 'D')
            {
                if(posY -1 < 0) continue;
                posY -= 1;
            }
            else if(dirs[i] == 'R')
            {
                if(posX +1 > 10) continue;
                posX += 1;
            }
            else if(dirs[i] == 'L')
            {
                if(posX -1 < 0) continue;
                posX -= 1;
            }
            //중복으로 도달하지않았으면 answer++
            if(recordPos[beforeX,beforeY,posX,posY] == 0)
            {
                recordPos[beforeX,beforeY,posX,posY] = 1;
                recordPos[posX,posY,beforeX,beforeY] = 1;
                answer++;
            }
        }
        return answer;
    }
}
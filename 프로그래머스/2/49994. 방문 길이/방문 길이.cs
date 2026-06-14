using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string dirs) {
        int answer = 0;
        //HashSet도 가능하고, int[,,,] 이거도 가능함
        int posX = 0;
        int posY = 0;
        HashSet<string> hash = new HashSet<string>();
        
        //좌표는 -5 ~ 5 이상으로 넘어갈수 없음.
        for(int i=0; i< dirs.Length; i++)
        {
            int beforeX = posX;
            int beforeY = posY;
            if(dirs[i] == 'U')
            {
                //위쪽으로 이동;
                if(ExistPos(posX, posY+1))
                {
                    posY += 1;
                }
            }
            else if(dirs[i] == 'D')
            {
                if(ExistPos(posX, posY-1))
                {
                    posY -= 1;
                }
            }
            else if(dirs[i] == 'R')
            {
                if(ExistPos(posX+1, posY))
                {
                    posX += 1;
                }
            }
            else if(dirs[i] == 'L')
            {
                if(ExistPos(posX-1, posY))
                {
                    posX -= 1;
                }
            }
            if(beforeX == posX && beforeY == posY) continue;
            
            //중복으로 도달하지않았으면 answer++
            string posStr = $"({posX},{posY}) -> ({beforeX},{beforeY})";
            string posStr2 = $"({beforeX},{beforeY}) -> ({posX},{posY})";
            if(!hash.Contains(posStr) && !hash.Contains(posStr2))
            {
                hash.Add(posStr);
                hash.Add(posStr2);
                answer++;
            }
        }
        return answer;
    }
    
    private bool ExistPos(int posX,int posY)
    {
        if(posX > 5 || posY > 5 || posX < -5 || posY < -5)
        {
            return false;
        }
        return true;
    }
    
}
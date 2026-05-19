using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;
        //딕셔너리로 n개이상 겹치면 그냥 OK 하면 될듯?
        Dictionary<int,int> numDict = new Dictionary<int,int>();
        for(int i=0; i < lines.GetLength(0); i++)
        {
            int startX = lines[i,0];
            int endX = lines[i,1];
            for(int j = startX; j < endX; j++)
            {
                
                if(!numDict.ContainsKey(j)) 
                {
                    numDict.Add(j,1);
                }
                else
                {
                    numDict[j]++;
                }
            }
        }
        //얼마나 겹치는지 체크
        foreach(int count in numDict.Values)
        {
            if(count > 1) answer++;
        }
        
        return answer;
    }
}
using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 0;
        Dictionary<string,int> dic = new Dictionary<string,int>();
        
        for(int i=0; i< clothes.GetLength(0); i++)
        {
            string name = clothes[i,0];
            string type = clothes[i,1];
            
            if(!dic.ContainsKey(type)) dic[type] = 1;
            else dic[type]++;
        }
        foreach(var item in dic.Keys)
        {
            if(answer ==0) answer = (dic[item] +1);
            else answer *= (dic[item] + 1);
        }
        //모두 착용안한 경우 뺌
        answer -= 1; 
        
        return answer;
    }
}
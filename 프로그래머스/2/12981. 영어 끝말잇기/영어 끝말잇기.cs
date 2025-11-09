using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
        Dictionary<string,int> dic = new Dictionary<string,int>();
        int count = 0;
        bool isFind = false;
        
        for(int i=0; i< words.Length; i++)
        {
            count = i;
            
            if(i != 0)
            {
                int beforeLastIndex = words[i-1].Length-1;
                char beforeLastChar = words[i-1][beforeLastIndex];
                if(beforeLastChar != words[i][0])
                {
                    isFind= true;
                    break;
                }
            }
            
            if(!dic.ContainsKey(words[i]))
            {
                dic[words[i]] = 1;
            }
            else
            {
                isFind = true;
                break;
            }
        }
        if(!isFind)
        {
            answer[0] = 0;
            answer[1] = 0;
        }
        else
        {
            answer[0] = (count % n) +1; //사람
            answer[1] = (count /n) +1; //횟수
        }
        
        return answer;
    }
}
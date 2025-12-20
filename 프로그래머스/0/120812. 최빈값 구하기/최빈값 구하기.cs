using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        //최빈값을 찾는다 (최빈값이 여러개면 -1)
        Dictionary<int,int> dic = new Dictionary<int,int>();
        
        for(int i=0; i< array.Length; i++)
        {
            if(!dic.ContainsKey(array[i])) dic[array[i]] = 1;
            else dic[array[i]]++;
        }
        //최빈값 탐색
        int max = 0;
        foreach(var index in dic.Keys)
        {
            int count = dic[index];
            if(max < count)
            {
                max = count;
                answer = index;
            }
            else if (max == count)
            {
                answer = -1;
            }
        }
        
        return answer;
    }
}
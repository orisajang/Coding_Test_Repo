using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        int answer = 0;
        
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int numLength = elements.Length; 
        
        for(int k=0; k< numLength; k++)
        {
            for(int i=0; i< numLength; i++)
            {
                //현재 i번째임
                int sum = 0;
                for(int j=0; j<= k; j++)
                {
                    
                    int index =  (i+j) % numLength;
                    sum+= elements[index];
                }
                //딕셔너리에 있는지 확인
                if(!dic.ContainsKey(sum))
                {
                    dic[sum] = 1;
                    answer++;
                }
            }
        }
        
        
        return answer;
    }
}
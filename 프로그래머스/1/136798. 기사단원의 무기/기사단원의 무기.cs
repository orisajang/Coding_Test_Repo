using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        //약수는? 해당하는 수의 절반만 해서 나누는수를 구하면됨
        
        for(int i=1; i<= number; i++)
        {
            List<int> nList = new List<int>();
            for(int j=1; j*j <=i; j++)
            {
                if(i%j == 0) 
                {
                    int mok = i/j;
                    
                    if(j == mok)
                    {
                        nList.Add(j);
                    }
                    else
                    {
                        nList.Add(j);
                        nList.Add(mok);
                    }
                }
            }
            int listCount = nList.Count;
            if(listCount > limit) listCount = power;
            answer += listCount;
            
        }
        
        
        return answer;
    }
}
using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int[] answer;
        List<int> list = new List<int>();
        if(n == 1)
        {
            for(int i=0; i<= slicer[1]; i++)
            {
                list.Add(num_list[i]);    
            }
        }
        else if(n == 2)
        {
            for(int i=slicer[0]; i< num_list.Length; i++)
            {
                list.Add(num_list[i]);
            }
        }
        else if(n == 3)
        {
            for(int i=slicer[0]; i<= slicer[1]; i++)
            {
                list.Add(num_list[i]);
            }
        }
        else if(n==4)
        {
            int count = slicer[2];
            for(int i=slicer[0]; i<= slicer[1]; i++)
            {
                count++;
                if(count >= slicer[2])
                {
                    count = 0;
                    list.Add(num_list[i]);    
                }
            }
        }
        answer = list.ToArray();
        
        
        return answer;
    }
}
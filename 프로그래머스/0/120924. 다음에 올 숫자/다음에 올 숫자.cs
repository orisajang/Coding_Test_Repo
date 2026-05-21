using System;

public class Solution {
    public int solution(int[] common) {
        
        int gap1 = common[1] - common[0];
        int gap2 = common[2] - common[1];
        
        int lastIndex = common.Length -1;
        if(gap1 == gap2)
        {
            return common[lastIndex] + gap1;
        }
        else
        {
            int multi = common[1] / common[0];
            
            return common[lastIndex] * multi;
        }
    }
}
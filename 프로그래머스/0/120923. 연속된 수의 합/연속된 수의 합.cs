using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        int buf = total / num;
        int bufMin = buf - (num / 2);
        int bufMax = buf + (num / 2);
        for(int i=bufMin; i<=bufMax; i++)
        {
            int sum = 0;
            for(int j=0; j< num; j++)
            {
                sum += (i+j);
            }
            if(sum == total)
            {
                for(int k=0; k< num; k++)
                {
                    answer[k] = i +k;
                }
                break;
            }
        }
        
        return answer;
    }
}
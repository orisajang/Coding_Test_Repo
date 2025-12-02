using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 0;
        //80 /  2배
        //3 2 2
        for(int i=0; i< box.Length; i++)
        {
            if(i==0) answer = box[i] / n;
            else 
            {
                answer *= box[i] / n;
            }
        }
        return answer;
    }
}
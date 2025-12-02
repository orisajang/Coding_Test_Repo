using System;

public class Solution {
    public int[] solution(int n) {
        //배열에 몇개 들어갈건지 계산
        int arrayLength = 0;
        if(n%2 == 0) arrayLength = n/2;
        else arrayLength = (n/2) +1;
        int[] answer = new int[arrayLength];
        //홀수 찾기
        int index = 0;
        for(int i=1; i<= n; i++)
        {
            if(i%2 != 0)
            {
               answer[index] = i;
               index++;
            }
        }
        
        return answer;
    }
}
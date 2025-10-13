using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        char c = s[0]; //c = b;
        int sameCount = 0;
        for(int i=0; i< s.Length; i++) //같은글자더하고 0되면 다음문자를 첫문자로
        {
            if(s[i] == c) sameCount++;
            else
            {
                sameCount--;
            }
            if(sameCount <= 0) 
            {
                answer++; //자른횟수 ++;
                if(i+1 < s.Length)
                {
                    c = s[i+1]; //남은 문자열의 첫번째로 바꿈
                    sameCount = 0;
                }
            }
        }
        if(sameCount !=0) answer++;
        
        return answer;
    }
}
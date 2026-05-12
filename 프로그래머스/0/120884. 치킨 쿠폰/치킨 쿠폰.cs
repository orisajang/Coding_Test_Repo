using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        
        while((chicken /10) > 0)
        {
            answer += chicken / 10;
            
            //만약 105마리였다면?
            chicken = (chicken/10)  + (chicken % 10);
        }
        return answer;
    }
}
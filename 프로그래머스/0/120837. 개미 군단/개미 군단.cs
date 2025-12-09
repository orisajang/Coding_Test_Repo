using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        answer += hp / 5;
        if(hp % 5 != 0)
        {
            hp = hp % 5;
            answer += hp /3;
            if(hp % 3 != 0)
            {
                hp = hp % 3;
                answer += hp;
            }
        }
        
        return answer;
    }
}
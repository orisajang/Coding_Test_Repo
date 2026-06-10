using System;

public class Solution {
    public int solution(int storey) {
        int answer = 0;
        
        while(storey != 0)
        {
            int num = storey % 10;
            if(num < 5) answer += num;
            else if(num > 5)
            {
                answer += (10- num);
                storey += 10;
            }
            else
            {
                //5인 경우 (다음 숫자까지 생각해야함)
                answer += num;
                int nextNum = (storey / 10) % 10;
                //다음숫자가 4면 4번하면되는데, 5가되면 5번해야함. 5로 가자
                //다음숫자가 5면 5번하면되는데, 6이되면 4번이므로 6이되는게 이득
                if(nextNum >= 5) 
                {
                    storey += 10;
                }
            }
            storey /= 10;
        }
        
        return answer;
    }
}